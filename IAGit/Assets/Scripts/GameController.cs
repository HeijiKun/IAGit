using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	public Tile[,] tablero;
	public GameObject tile;
	public GameObject tile1;
	private bool myTurn;

	// Use this for initialization
	void Start ()
	{

		tablero = new Tile[8,8];
		dibujaTablero ();
		myTurn = true;

	}
	
	// Update is called once per frame
	void Update ()
	{

		if (myTurn)
		{

			if (Input.GetButtonDown ("Fire1"))
			{

				RaycastHit hit;
				Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);

				if (Physics.Raycast (ray, out hit))
				{
					if (hit.transform.tag.Equals ("Tile"))
					{

						Tile tile = hit.collider.gameObject.GetComponent<Tile> ();
						tile.instancia ();

						Debug.Log (((Tile)tablero [tile.intX, tile.intY]).intX + " - " + ((Tile)tablero [tile.intX, tile.intY]).intY);

						myTurn = false;

					}
				}

			}

		}
		else
		{
			if (Input.GetButtonDown ("Fire1"))
			{
				myTurn = true;
			}
		}


	}

	void dibujaTablero()
	{

		for (int i = 0; i < 8; i+=2)
		{
			for (int j = 1; j < 8; j+=2)
			{
				Tile casilla = Instantiate (tile, new Vector3 (i, -0.03f, j), Quaternion.identity).GetComponent<Tile> ();
				casilla.intX = i;
				casilla.intY = j;
				tablero [i, j] = casilla;
			}
		}

		for (int i = 1; i < 8; i+=2)
		{
			for (int j = 0; j < 8; j+=2)
			{
				Tile casilla = Instantiate (tile, new Vector3 (i, -0.03f, j), Quaternion.identity).GetComponent<Tile> ();
				casilla.intX = i;
				casilla.intY = j;
				tablero [i, j] = casilla;
			}
		}

		for (int i = 0; i < 8; i+=2)
		{
			for (int j = 0; j < 8; j+=2)
			{
				Tile casilla = Instantiate (tile1, new Vector3 (i, -0.03f, j), Quaternion.identity).GetComponent<Tile> ();
				casilla.intX = i;
				casilla.intY = j;
				tablero [i, j] = casilla;
			}
		}

		for (int i = 1; i < 8; i+=2)
		{
			for (int j = 1; j < 8; j+=2)
			{
				Tile casilla = Instantiate (tile1, new Vector3 (i, -0.03f, j), Quaternion.identity).GetComponent<Tile> ();
				casilla.intX = i;
				casilla.intY = j;
				tablero [i, j] = casilla;
			}
		}
	}
}
