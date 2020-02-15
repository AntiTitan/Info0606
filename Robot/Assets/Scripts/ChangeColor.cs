using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ChangeColor : MonoBehaviour
{
	GameObject RedQuad;
	GameObject BlueQuad;
	GameObject GreenQuad;
	Renderer CubeRenderer;
    // Start is called before the first frame update
    void Start()
    {
        RedQuad = GameObject.FindGameObjectWithTag("RedQuad");
		BlueQuad = GameObject.FindGameObjectWithTag("BlueQuad");
		GreenQuad = GameObject.FindGameObjectWithTag("GreenQuad");
		CubeRenderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
		Vector3 RedQuadPos = RedQuad.transform.position;
		Vector3 RedQuadScale = RedQuad.transform.localScale;
		Vector3 BlueQuadPos = BlueQuad.transform.position;
		Vector3 BlueQuadScale = BlueQuad.transform.localScale;
		Vector3 GreenQuadPos = GreenQuad.transform.position;
		Vector3 GreenQuadScale = GreenQuad.transform.localScale;

		float xmin = RedQuadPos.x - RedQuadScale.x / 2;
		float xmax = RedQuadPos.x + RedQuadScale.x / 2;
		float zmin = RedQuadPos.z - RedQuadScale.z / 2;
		float zmax = RedQuadPos.z + RedQuadScale.z / 2;

		float Bxmin = BlueQuadPos.x - BlueQuadScale.x / 2;
		float Bxmax = BlueQuadPos.x + BlueQuadScale.x / 2;
		float Bzmin = BlueQuadPos.z - BlueQuadScale.z / 2;
		float Bzmax = BlueQuadPos.z + BlueQuadScale.z / 2;

		float Gxmin = GreenQuadPos.x - GreenQuadScale.x / 2;
		float Gxmax = GreenQuadPos.x + GreenQuadScale.x / 2;
		float Gzmin = GreenQuadPos.z - GreenQuadScale.z / 2;
		float Gzmax = GreenQuadPos.z + GreenQuadScale.z / 2;


		if (transform.position.x > xmin && transform.position.x < xmax && transform.position.z > zmin && transform.position.z < zmax){
			CubeRenderer.material.SetColor("_Color", Color.red);
		}
		else{
			if(transform.position.x > Bxmin && transform.position.x < Bxmax && transform.position.z > Bzmin && transform.position.z < Bzmax){
				CubeRenderer.material.SetColor("_Color", Color.blue);
			}
			else{
				if(transform.position.x > Gxmin && transform.position.x < Gxmax && transform.position.z > Gzmin && transform.position.z < Gzmax){
					CubeRenderer.material.SetColor("_Color", Color.green);
				}
				else{
					CubeRenderer.material.SetColor("_Color", Color.white);
				}
			}
		}
		
	}
}
