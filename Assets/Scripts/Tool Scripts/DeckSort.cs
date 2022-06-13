using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class DeckSort : MonoBehaviour
{
    public Transform unsortedDeck;
    public List<GameObject> unsortedList;
    public List<GameObject> sortedList;
    public GameObject sortedDeck;
    
    private void Start() 
    {
        var temp = new List<GameObject>();
        foreach (Transform child in unsortedDeck)
        {
            temp.Add(child.gameObject);
        }
        unsortedList = temp;
        sortedList = unsortedList;
        sortedList.Sort(CompareListByName);
        GameObject x;
        foreach (GameObject card in sortedList)
        {
            x = card;
            x.transform.parent = sortedDeck.transform;
        }
    }

    private static int CompareListByName(GameObject i1, GameObject i2)
    {
        return i1.name.CompareTo(i2.name); 
    }
}
