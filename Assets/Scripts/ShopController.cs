using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopController : MonoBehaviour
{
    public List<Transform> shopSpotsLocation;
    public List<Transform> reserveSpotsLocation;


    [Header("DeckList")]
    public GameObject shopListController;

    void Start()
    {
        GameStart();
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

}
