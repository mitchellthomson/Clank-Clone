using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class shopPurchase : MonoBehaviour
{
    public GameObject curCard;
    Sprite displaySprite;
    public ShopController shopController;
    

    public void AssignSpot()
    {
        displaySprite = curCard.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite;
        
    }

    private void OnMouseDown()
    {
        if(curCard!= null && curCard.GetComponent<DisplayCard>().inShop == true)
        {
            Debug.Log("card" + curCard.name + "selected");
            shopController.DisplaySelectedShopCard(displaySprite, true);
        }
    }

    void OnMouseEnter()
    {
        if(curCard!= null && curCard.GetComponent<DisplayCard>().inShop == true)
        {
            Debug.Log("Mouse is over " + curCard.name);
            shopController.DisplaySelectedShopCard(displaySprite);
        }
        
    }

    void OnMouseExit()
    {
        if(curCard!= null && curCard.GetComponent<DisplayCard>().inShop == true)
        {
            Debug.Log("Mouse has exit Shop.");
            shopController.DisplaySelectedShopCard(null);
        }
        
    }
}
