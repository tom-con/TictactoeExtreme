using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileController : MonoBehaviour { 

	public Vector2 coords;

	private int controlledBy;
	private bool selectable;

	void Start () {
		controlledBy = 0;
		selectable = true;
	}

	void OnMouseDown(){
		if(selectable){
			Hashtable currPlayer = PlayersController.GetCurrentPlayer();
			UpdateControl (currPlayer);
			GameboardController.CheckWin ();
			PlayersController.UpdateCurrentPlayer ();
		}
	}

	public void UpdateControl (Hashtable player){
		Renderer r = GetComponent<Renderer> ();
		selectable = false;
		controlledBy = (int)player["number"];
		Material currMat = gameObject.GetComponent<Material> ();
		r.material = (Material)player["material"];
	}
}
