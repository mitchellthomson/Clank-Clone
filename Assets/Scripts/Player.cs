using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Game Info")]
    public int turnOrder;
    public GameObject playerDeck;

    [Header("Player Stats")]
    public int health;
    public int score;
    public int playerGold;
    

    [Header("Hand Info")]
    public List<GameObject> playerHand;
    public int playerSkill;
    public int playerMove;
    public int playerAttack;
    public int playerDraw;
    public int playerClank;


    [Header("Player Deck Info")]
    public List<GameObject> playerDrawPile;
    public List<GameObject> playerDiscardPile;

    public static void Start()
    {
        
    }
}
