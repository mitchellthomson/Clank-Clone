using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopController : MonoBehaviour
{
    public List<Transform> shopSpotsLocation;
    public List<Transform> reserveSpotsLocation;

    [Header("Display Card")]
    public GameObject shopDisplayCard;
    public bool isCardSelectedBuy;

    [SerializeField] private Button confirmShopButton;
    [SerializeField] private Button denyShopButton;

    SpriteRenderer displayRenderer;
    GameObject selectedCard;

    [Header("DeckList")]
    public GameObject shopListController;

    void Start()
    {
        RefreshShop();
        displayRenderer = shopDisplayCard.GetComponent<SpriteRenderer>();
    }

    public void RefreshShop()
    {
        var deck = shopListController.GetComponent<ShopDeckController>().shopDeckList;
        GameObject shopCard;

        foreach(Transform spot in shopSpotsLocation)
        {
            if(spot.childCount < 1)
            {
                shopCard = Instantiate(deck[0], new Vector3(spot.position.x,spot.position.y,spot.position.z), Quaternion.identity);
                shopCard.name = deck[0].name;
                shopCard.transform.parent = spot;
                spot.GetComponent<shopPurchase>().curCard = shopCard;
                shopCard.GetComponent<DisplayCard>().inShop = true;
                deck.RemoveAt(0);

                spot.GetComponent<shopPurchase>().AssignSpot();
            }
        }

    }

    public void DisplaySelectedShopCard(Sprite selectedCardSprite, bool selected = false, GameObject curCard = null)
    {
        if(selected == true)
        {
            isCardSelectedBuy = true;
            selectedCard = curCard;
        }

        if(isCardSelectedBuy == false)
        {
            displayRenderer.sprite = selectedCardSprite;
        }
        
    }

    public void CancelButton()
    {
        isCardSelectedBuy = false;
        displayRenderer.sprite = null;
    }

    public void ConfirmButton()
    {
        Destroy(selectedCard);
        displayRenderer.sprite = null;
        isCardSelectedBuy = false;
    }
    
    
}
