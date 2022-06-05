using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "BaseCard")]
public class CardBase : ScriptableObject {

	public new string name;

	public Sprite artwork;

	public int skill;
	public int attack;
	public int movement;
    public int clank;
	public int draw;

	public int skillCost;

	public bool companion;
	public bool gem;

	public bool aquire;
	
	public enum aquireType{
		one=1,
		two=2,
		three=3
	};


}
