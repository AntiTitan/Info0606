using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdatePositionCamera : MonoBehaviour
{
    Camera CameraRobot;
    Camera CameraCube;
    Camera CameraMain;
    // Start is called before the first frame update
    void Start()
    {
        CameraRobot = GameObject.Find("Camera_robot").GetComponent<Camera>();
        CameraCube = GameObject.Find("Camera_cube").GetComponent<Camera>();
        CameraMain = GameObject.Find("Camera_main").GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        CameraCube.gameObject.SetActive(false);
        if (Input.GetKey(KeyCode.R))
        {
            CameraRobot.gameObject.SetActive(true);
            CameraMain.gameObject.SetActive(false);
        }
        if (Input.GetKey(KeyCode.M))
        {
            CameraMain.gameObject.SetActive(true);
            CameraRobot.gameObject.SetActive(false);
            
        }
    }
    
}
