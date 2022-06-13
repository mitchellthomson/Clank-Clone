using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


public class DeckController : MonoBehaviour
{
    public List<GameObject> deckList = new List<GameObject>();
    
    public GameObject deck;

    public void Start() 
    {
        Shuffle(deckList);
    }

    public void Shuffle(List<GameObject> list)
    {
        for (int i = list.Count-1; i > 0; i--)
		{
			int rnd = Random.Range(0,i);
			
			var temp = list[i];
			
			list[i] = list[rnd];
			list[rnd] = temp;
		}
        CreateDeck(deckList);
    }

    public void CreateDeck(List<GameObject> list)
    {
        
        //GameObject temp;
        foreach (GameObject card in deckList)
        {
            GameObject newCard = Instantiate(card,transform.position,Quaternion.identity);
            newCard.name = card.name;
            newCard.transform.parent = deck.transform;
        }
    }
}
