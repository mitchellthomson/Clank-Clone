using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Base Card")]
public class CardBase : ScriptableObject {
	public enum MonsterLoot{Test1, Test2, Test3};
	public enum MonsterCondition{None, CrystalCave, Depths};

	public new string name;
	public Sprite artwork;
	[Header("Card Stats")]
	public int skill;
	public int attack;
	public int movement;
    public int clank;
	public int draw;
	public bool isGem;

	[Header("Shop Attributes")]
	public int skillCost;
	public bool aquire;
	public bool arrive;
	public bool dragonAttack;
	public bool danger;

	[Header("Companion")]
	public bool isCompanion;


	[Header("Monster")]
	public bool isMonster;
	public int attackNeeded;
    public MonsterLoot monsterLoot;
	public MonsterCondition monsterCondition;

}
