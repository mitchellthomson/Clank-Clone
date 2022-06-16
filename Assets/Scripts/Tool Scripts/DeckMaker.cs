using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class DeckMaker : MonoBehaviour
{
    public Transform deck;
    public List<GameObject> playerDeckList = new List<GameObject>();
    

    public void Awake()
    {
        foreach (Transform child in deck)
        {
            playerDeckList.Add(child.gameObject);
        }
    }

}
