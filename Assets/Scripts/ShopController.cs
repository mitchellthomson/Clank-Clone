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

    [Header("DeckList")]
    public GameObject shopListController;

    void Start()
    {
        GameStart();
        displayRenderer = shopDisplayCard.GetComponent<SpriteRenderer>();
    }

    public void GameStart()
    {
        var deck = shopListController.GetComponent<ShopDeckController>().shopDeckList;

        foreach(Transform spot in shopSpotsLocation)
        {
            var shopCard = Instantiate(deck[0], new Vector3(spot.position.x,spot.position.y,spot.position.z), Quaternion.identity);
            shopCard.name = deck[0].name;
            shopCard.transform.parent = spot;
            spot.GetComponent<shopPurchase>().curCard = shopCard;
            shopCard.GetComponent<DisplayCard>().inShop = true;
            deck.RemoveAt(0);

            spot.GetComponent<shopPurchase>().AssignSpot();
        }

    }

    public void DisplaySelectedShopCard(Sprite selectedCard, bool selected = false)
    {
        if(selected == true)
        {
            isCardSelectedBuy = true;
        }

        if(isCardSelectedBuy == false)
        {
            displayRenderer.sprite = selectedCard;
        }
        
    }

    public void CancelButton()
    {
        isCardSelectedBuy = false;
        displayRenderer.sprite = null;
    }
    

}
