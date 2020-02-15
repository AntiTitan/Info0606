using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CentreCube : MonoBehaviour
{
    GameObject Cube;
    // Start is called before the first frame update
    void Start()
    {
        Cube = GameObject.FindWithTag("Cube");
        //CameraCube = Camera.transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Cube.transform);
    }
}
