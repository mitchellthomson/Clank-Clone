using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Tile", menuName = "Tile")]
public class Tile : ScriptableObject 
{
    public enum TileType {None, Minor, Major, Artifact, Monkey};
    public enum SpecialTile {None, Trash, DragonEgg};
    public Sprite FrontDisplay;

    [Header("Instant")]
    public int Score;
    public int Skill;
    public int Gold;
    public int Draw;
    public bool isSpecial;
    
    [Header("Later Usage")]
    public int Attack;
    public int Boot;
    public int Health;
}

