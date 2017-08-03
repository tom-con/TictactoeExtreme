using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameboardController : MonoBehaviour {

	public GameObject tile;
	public Camera mainCam;
	public float cameraHeightMultiplier;
	public int rows;
	public int columns;

	private List<GameObject> tiles = new List<GameObject>();
	private float cameraScaleMultiplier;

	void Start () {
		InstantiateBoard ();
		UpdateCamera();
	}

	void InstantiateBoard() {
		cameraScaleMultiplier = ((1.5f * rows) * -1) + 1.5f;
		cameraHeightMultiplier *= rows;
		for(int x = 0; x < rows; x++){
			for(int y = 0; y < columns; y++){
				Vector3 pos = new Vector3 (-3 * x, 0.0f, -3 * y);
				Instantiate (tile, pos, Quaternion.identity);
			}
		}
	}

	void UpdateCamera() {
		mainCam.transform.position = new Vector3 (cameraScaleMultiplier, cameraHeightMultiplier, cameraScaleMultiplier);
	}
		
	void Update () {
		
	}
}
