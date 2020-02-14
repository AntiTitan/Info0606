using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Realisation : MonoBehaviour
{
    Camera CameraRobot;
    Camera CameraCube;
    Camera CameraMain;
    Camera MainCamera;
    // Start is called before the first frame update
    void Start()
    {
        CameraRobot = GameObject.Find("Camera_robot").GetComponent<Camera>();
        //CameraCube = GameObject.Find("Camera_cube").GetComponent<Camera>();
        CameraMain = GameObject.Find("Camera_main").GetComponent<Camera>();
        MainCamera = GameObject.Find("MainCamera").GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            // CameraRobot.enabled = true;
            // CameraMain.enabled = false;
            // CameraCube.enabled = false;

            //ou
            MainCamera.gameObject.SetActive(false);
            CameraRobot.gameObject.SetActive(true);
            CameraMain.gameObject.SetActive(false);
            //CameraCube.gameObject.SetActive(false);
        }
        if (Input.GetKey(KeyCode.M))
        {
            // CameraRobot.enabled = false;
            // CameraMain.enabled = true;
            // CameraCube.enabled = false;

            //ou
            MainCamera.gameObject.SetActive(false);
            CameraMain.gameObject.SetActive(true);
            CameraRobot.gameObject.SetActive(false);
            //CameraCube.gameObject.SetActive(false);
        }
        /*
        if (Input.GetKey(KeyCode.C))
        {
            // CameraRobot.enabled = false;
            // CameraMain.enabled = false;
            // CameraCube.enabled = true;

            //ou
            MainCamera.gameObject.SetActive(false);
            CameraCube.gameObject.SetActive(true);
            CameraMain.gameObject.SetActive(false);
            CameraRobot.gameObject.SetActive(false);
        }*/
        if (Input.GetKey(KeyCode.P))
        {
            // CameraRobot.enabled = false;
            // CameraMain.enabled = false;
            // CameraCube.enabled = true;

            //ou
            MainCamera.gameObject.SetActive(true);
            //CameraCube.gameObject.SetActive(false);
            CameraMain.gameObject.SetActive(false);
            CameraRobot.gameObject.SetActive(false);
        }
    }
}
