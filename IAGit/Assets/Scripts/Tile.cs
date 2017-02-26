using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour {

	public GameObject posFicha;
	public GameObject ficha;

	public int intX, intY;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

//		if (Input.GetMouseButtonDown (0))
//		{
//			Instantiate (ficha, posFicha.transform.position, Quaternion.identity);
//		}

	}

	public void instancia()
	{
		Instantiate (ficha, posFicha.transform.position, Quaternion.identity);
	}
}
