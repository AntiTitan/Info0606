using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMain : MonoBehaviour
{
    GameObject CameraMain;
    GameObject MainCamera;
    // Start is called before the first frame update
    void Start()
    {
        CameraMain = GameObject.FindWithTag("Camera_main");
        MainCamera = GameObject.FindWithTag("MainCamera");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.M))
        {
            CameraMain.gameObject.SetActive(true);
            MainCamera.gameObject.SetActive(false);
        }
        if (Input.GetKey(KeyCode.P))
        {
            MainCamera.gameObject.SetActive(true);
            CameraMain.gameObject.SetActive(false);
        }

        if (Input.GetKey("[8]"))
        {
            CameraMain.transform.Rotate(1.0f, 0.0f, 0.0f, Space.Self);
        }
        if (Input.GetKey("[2]"))
        {
            CameraMain.transform.Rotate(-1.0f, 0.0f, 0.0f, Space.Self);
        }
        if (Input.GetKey("[6]"))
        {
            CameraMain.transform.Rotate(0.0f, 1.0f, 0.0f, Space.Self);
        }
        if (Input.GetKey("[4]"))
        {
            CameraMain.transform.Rotate(0.0f, -1.0f, 0.0f, Space.Self);
        }
        if (Input.GetKey("[1]"))
        {
            CameraMain.transform.Rotate(0.0f, 0.0f, 1.0f, Space.Self);
        }
        if (Input.GetKey("[3]"))
        {
            CameraMain.transform.Rotate(0.0f, 0.0f, -1.0f, Space.Self);
        }

    }
}
