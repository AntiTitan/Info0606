using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
   

    public GameObject SphereNoire;
    public GameObject SphereRose;
    public GameObject SphereRoseSecrete;
    public float hauteur;
    bool flagMessageDebut=false;
    bool flagDebutJeu=false;
    string messageDebut = "Règles du jeu : \nDéplacez vous avec les touches directionnelles. \nVous devez faire sortir la boule secrète du plateau pour gagner. \nPassez sur la case verte pour débuter le jeu. \nAttention à ne pas tomber... ";
    // Start is called before the first frame update
    void createSpheres()
    {
        for (int i = 0; i < 7; i++)
        {
            Instantiate(SphereNoire, new Vector3(Random.Range(-10.0f, 10.0f), hauteur, Random.Range(-10.0f, 10.0f)), Quaternion.identity);
        }
        for (int i = 0; i < 6; i++)
        {
            Instantiate(SphereRose, new Vector3(Random.Range(-10.0f, 10.0f), hauteur, Random.Range(-10.0f, 10.0f)), Quaternion.identity);
        }
        Instantiate(SphereRoseSecrete, new Vector3(Random.Range(-10.0f, 10.0f), hauteur, Random.Range(-10.0f, 10.0f)), Quaternion.identity);
    }
    void Start()
    {

    }
    void OnCollisionEnter(Collision collision)  
        {
            if((collision.gameObject.name == "Plane") && (!flagDebutJeu )){
                flagMessageDebut = true;
                Debug.Log ("Col Plan");
            }
            else{
                flagMessageDebut = false;
            }
            if(collision.gameObject.name == "StartQuad"){
                flagMessageDebut = false;
                flagDebutJeu = true;
                Debug.Log ("Sphères créées");
                createSpheres(); 
            }
            
        }

    void OnCollisionExit(Collision collision)
        {
            if(collision.gameObject.name == "StartQuad"){
                
            }
        }

    void OnGUI()
	{
		int l = 300; //largeur panneau
		int h = 200; //hauteur panneau
		int ox = Screen.width/2-l/2; //position panneau pour le centrer en X
		int oy = Screen.height/2-h/2; //position panneau pour le centrer en Y
		
		if(flagMessageDebut == true)
        {  	
		    GUI.TextField(new Rect(ox,oy,l,h),messageDebut);
		}
	}

    


}

