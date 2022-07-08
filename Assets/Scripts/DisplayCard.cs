using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DisplayCard : MonoBehaviour
{
    public CardBase card;
    public SpriteRenderer spriteRenderer;
    
    public Vector3 cachedScale;
    void Start()
    {
        spriteRenderer.sprite = card.artwork;
        cachedScale = transform.localScale;
    }

    void OnMouseOver()
    {
        //If your mouse hovers over the GameObject with the script attached, output this message
        Debug.Log("Mouse is over GameObject.");
    }

    void OnMouseExit()
    {
        //The mouse is no longer hovering over the GameObject so output this message each frame
        print("Mouse is no longer on GameObject.");
    }

}
