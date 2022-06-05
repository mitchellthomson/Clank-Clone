using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayCard : MonoBehaviour
{
    public CardBase card;
    public SpriteRenderer spriteRenderer;
    
    void Start()
    {
        spriteRenderer.sprite = card.artwork;
    }

}
