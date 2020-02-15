using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    class infoSphere{
        Gameobject Sphere;
        int etat;
    }
    infoSphere[15] Balle ;
    // Start is called before the first frame update
    void Start()
    {
        StartQuad = GameObject.FindGameObjectWithTag("StartQuad");
        Robot = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {

        
    }
}
