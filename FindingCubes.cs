using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindingCubes : MonoBehaviour
{

    public GameObject cube;

    // Start is called before the first frame update
    void Start()
    {
        if (cube == null)
            cube = GameObject.FindWithTag("Cube");
        Debug.Log("I found a cube!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
