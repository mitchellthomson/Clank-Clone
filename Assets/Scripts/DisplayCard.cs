using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DisplayCard : MonoBehaviour
{
    public CardBase card;
    public SpriteRenderer spriteRenderer;
    public bool inShop;
    
    Vector3 cachedScale;
    Vector3 cachedPos;
    void Start()
    {
        spriteRenderer.sprite = card.artwork;
        cachedScale = transform.localScale;
        cachedPos = transform.localPosition;
    }

    void OnMouseOver()
    {
        //If your mouse hovers over the GameObject with the script attached, output this message
        if(inShop == false)
        {
            Debug.Log("Mouse is over " + card.name);
            transform.localScale = new Vector3(2f, 2f, 2f);
            transform.localPosition = new Vector3(cachedPos.x, cachedPos.y, cachedPos.z - 2f);
        }
    }

    void OnMouseExit()
    {
        //The mouse is no longer hovering over the GameObject so output this message each frame
        if(inShop == false)
        {
            print("Mouse is no longer on GameObject.");
            transform.localScale = cachedScale;
            transform.localPosition = cachedPos;
        }
    }

}
