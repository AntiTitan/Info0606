using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_spot : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.eulerAngles = new Vector3(60, 0, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.eulerAngles = new Vector3(60, 180, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.eulerAngles = new Vector3(60, -90, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.eulerAngles = new Vector3(60, 90, 0);
        }

    }
}