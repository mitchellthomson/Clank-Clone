using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardMaker : MonoBehaviour
{
    public DisplayCard displayCard;

    public CardBase[] cards;

    public GameObject cardOriginal;

    public void Start() 
    {
        cards = Resources.LoadAll<CardBase>("Starting");

        foreach(var card in cards)
        {
            displayCard.card = card;
            
            GameObject newCard = Instantiate(cardOriginal);
            newCard.name = card.name;
        }
    }
}

