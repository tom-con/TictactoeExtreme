using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileController : MonoBehaviour { 

	private int controlledBy;
	private bool selectable;

	void Start () {
		controlledBy = 0;
		selectable = true;
	}

	void OnMouseDown(){
		Hashtable currPlayer = PlayersController.GetCurrentPlayer();
		Debug.Log ("Worked");
		UpdateControl (currPlayer);
		PlayersController.UpdateCurrentPlayer ();
	}

	public void UpdateControl (Hashtable player){
		selectable = false;
		controlledBy = (int)player["number"];
		Material currMat = gameObject.GetComponent<Material> ();
		currMat = (Material)player["material"];
	}

}
