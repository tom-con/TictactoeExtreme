using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayersController : MonoBehaviour {

	public Material[] flags;
	public int numPlayers;

	private List<Hashtable> players;

	void Start () {
		players = new List<Hashtable> ();
		CreatePlayers ();
	}

	void CreatePlayers(){
		for(int x = 1; x <= numPlayers; x++){
			Hashtable newPlayer = new Hashtable ();
			newPlayer.Add ("number", x);
			newPlayer.Add ("material", flags[x-1]);
			players.Add (newPlayer);
		}
	}
}
