using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    bool flagGagne=false;
    string messageGagne="Vous avez gagné !!!!\nBravo !!";
    bool flagPerdu=false;
    string messagePerdu="Oh lala !!!!\nC'est perdu...";
    // Start is called before the first frame update
    void Start()
    {
    }
    void OnTriggerEnter(Collider collision)  
    {
        if(collision.gameObject.name == "Socle"){
            Debug.Log("perdu");
            flagPerdu=true;
        }
        if(collision.gameObject.name == "SphereRoseSecrete(Clone)"){
            Debug.Log("gagne");
            flagGagne=true;
        }
    }
    // Update is called once per frame
    void OnGUI()
	{
		int l = 300; //largeur panneau
		int h = 200; //hauteur panneau
		int ox = Screen.width/2-l/2; //position panneau pour le centrer en X
		int oy = Screen.height/2-h/2; //position panneau pour le centrer en Y
		
		if(flagPerdu == true)
        {  	
		    GUI.TextField(new Rect(ox,oy,l,h),messagePerdu);
		}
        if(flagGagne == true)
        {  	
		    GUI.TextField(new Rect(ox,oy,l,h),messageGagne);
		}
	}
}
