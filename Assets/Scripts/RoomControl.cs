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
    public int minorCount;
    public List<GameObject> minorSecrets;
    public int majorCount;
    public List<GameObject> majorSecret;
    public int artifactCount;
    public List<GameObject> artifact;

}
