﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameboardController : MonoBehaviour {


	public GameObject tile;
	public Camera mainCam;
	public float cameraHeightMultiplier;
	public int rows;
	public int columns;

	private List<Hashtable> board;
	private float cameraScaleMultiplier;

	public class Tile

	void Start () {
		board = new List<Hashtable>();
		InstantiateBoard ();
		UpdateCamera();
	}

	void InstantiateBoard() {
		cameraScaleMultiplier = ((1.5f * rows) * -1) + 1.5f;
		cameraHeightMultiplier *= rows;
		for(int x = 0; x < rows; x++){
			for(int y = 0; y < columns; y++){
				InstantiateNewTile (x, y);
			}
		}
	}

	void InstantiateNewTile(int x, int y){
		Vector2 coords = new Vector2 (x, y);
		Hashtable thisTile = new Hashtable ();
		thisTile.Add ("coords", coords);
		thisTile.Add("taken", false);
		board.Add(thisTile);
		Vector3 pos = new Vector3 (-3 * x, 0.0f, -3 * y);
		GameObject newTile = Instantiate (tile, pos, Quaternion.identity);
		newTile.GetComponent<TileController> ().coords = coords;
	}

	void UpdateCamera() {
		mainCam.transform.position = new Vector3 (cameraScaleMultiplier, cameraHeightMultiplier, cameraScaleMultiplier);
	}

	public static void UpdateTile(int playerNum){
		
	}
		
	public static void CheckWin () {
		
	}
}
