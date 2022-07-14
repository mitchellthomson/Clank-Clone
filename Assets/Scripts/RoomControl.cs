using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomControl : MonoBehaviour
{
    public enum RoomType {Standard, Cave, Market};

    [Header("Room Info")]
    public RoomType roomType;
    
    public bool isDepths;
    public bool isHealingRoom;

    [Header("Player Info")]
    public int playerCount;

    [Header("Pathing Rooms")]

    public GameObject[] roomConnections;

    [Header("Pathing Paths")]

    public Paths[] pathConnections;

    [Header("Loot")]
    public bool isMinor;
    public int minorCount;
    public List<GameObject> minorSecrets;
    [Space (5)]
    public bool isMajor;
    public int majorCount;
    public List<GameObject> majorSecret;
    [Space (5)]
    public bool isArtifact;
    public int artifactCount;
    public List<GameObject> artifact;

}
