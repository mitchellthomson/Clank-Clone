using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CavnasMaker : MonoBehaviour
{
    public float x;
    public float y;
    public float z;
    // Start is called before the first frame update
    void Start()
    {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.position = new Vector3(22, 20, 1);
        cube.transform.localScale = new Vector3(44, y, z);
    }

}
