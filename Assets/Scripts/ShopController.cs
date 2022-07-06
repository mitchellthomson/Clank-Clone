using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopController : MonoBehaviour
{
    public List<Transform> shopSpotsLocation;
    public List<Transform> reserveSpotsLocation;


    [Header("DeckList")]
    public GameObject shopListController;
    public List<GameObject> shopDeckList;
    public GameObject reserveListController;
    public List<GameObject> reserveDeckList; 
    // Start is called before the first frame update
    void Start()
    {
        shopDeckList = shopListController.GetComponent<ShopDeckController>().shopDeckList;
    }

}
