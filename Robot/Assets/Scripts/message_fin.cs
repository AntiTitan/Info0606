
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class message_fin : MonoBehaviour {

private bool flag = false;
private string messageCol="Starting..." ;
	
	// Use this for initialization
void Start () 
	{
		flag = false;
	}

void OnCollisionEnter(Collision collision)  
	{
        if(collision.gameObject.name == "StartQuad"){
            flag = true;
            Debug.Log ("Message collision visible");
        }
		
	}

void OnCollisionExit(Collision collision)
	{
        if(collision.gameObject.name == "StartQuad"){
            flag = false;
            Debug.Log ("Message collision caché");
        }
	}

void OnGUI()
	{
		int l = 250; //largeur panneau
		int h = 250; //hauteur panneau
		int ox = Screen.width/2-l/2; //position panneau pour le centrer en X
		int oy = Screen.height/2-h/2; //position panneau pour le centrer en Y
		
		if(flag == true)
        {  	
		    GUI.TextField(new Rect(ox,oy,l,h),messageCol);
		}
	}
}