using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shopPurchase : MonoBehaviour
{
    public GameObject curCard;
    public GameObject shopDisplayCard;
    Sprite displaySprite;

    public void AssignSpot()
    {
        displaySprite = curCard.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite;
    }

    private void OnMouseDown()
    {
        if(curCard!= null && curCard.GetComponent<DisplayCard>().inShop == true)
        {
            Debug.Log("card bought");
        }
    }

    void OnMouseEnter()
    {
        if(curCard!= null && curCard.GetComponent<DisplayCard>().inShop == true)
        {
            Debug.Log("Mouse is over " + curCard.name);
            shopDisplayCard.GetComponent<SpriteRenderer>().sprite = displaySprite;
        }
        
    }

    void OnMouseExit()
    {
        if(curCard!= null && curCard.GetComponent<DisplayCard>().inShop == true)
        {
            Debug.Log("Mouse has exit Shop.");
            shopDisplayCard.GetComponent<SpriteRenderer>().sprite = null;
        }
        
    }
}
