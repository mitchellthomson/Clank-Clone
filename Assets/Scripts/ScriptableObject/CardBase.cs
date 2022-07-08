using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Base Card")]
public class CardBase : ScriptableObject {
	public enum MonsterLoot{None, Test2, Test3};
	public enum MonsterCondition{None, CrystalCave, Depths};

	public new string name;
	public Sprite artwork;
	[Header("Card Stats")]
	public int skill;
	public int attack;
	public int movement;
    public int clank;
	public int removeClank;
	public int draw;
	public int victoryPoints;
	public int gold;
	public bool isGem;

	[Header("Card Special")]
	public bool isSpecial;

	[Header("Shop Attributes")]
	public int skillCost;
	public bool aquire;
	public bool arrive;
	public bool dragonAttack;
	public bool danger;

	[Header("Companion")]
	public bool isCompanion;
	public bool isRebel;


	[Header("Monster")]
	public bool isMonster;
	public int attackNeeded;
    public MonsterLoot monsterLoot;
	public MonsterCondition monsterCondition;

	[Header("Device")]
	public bool isDevice;

}
