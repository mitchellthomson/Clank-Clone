using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerDeckController : MonoBehaviour
{
    public List<GameObject> playerDeckList;
    public List<GameObject> playerDiscardList;

    public void Start() 
    {
        Shuffle(playerDeckList);
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
        
    }
}
