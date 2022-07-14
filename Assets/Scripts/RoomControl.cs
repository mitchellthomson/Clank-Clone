using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomControl : MonoBehaviour
{
    public enum RoomType {Standard, Cave, Market};
    [Header("Room Info")]
    public RoomType roomType;

    public bool isDepths;
    [Header("Player Info")]
    public int playerCount;

    [Header("Pathing Rooms")]

    public GameObject[] roomConnections;

    [Header("Pathing Paths")]

    public Paths[] pathConnections;

    [Header("Loot")]
    public int minor;
    public int major;
    public int artifact;
}
