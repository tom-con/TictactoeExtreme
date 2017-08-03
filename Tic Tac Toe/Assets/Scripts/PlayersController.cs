using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayersController : MonoBehaviour {

	public Material[] flags;
	public static int numPlayers;
	public static List<Hashtable> players;

	private static int currentPlayer;

	void Start () {
		numPlayers = 2;
		currentPlayer = 0;
		players = new List<Hashtable> ();
		CreatePlayers ();
	}

	void CreatePlayers(){
		for(int x = 0; x < numPlayers; x++){
			Debug.Log (numPlayers);
			Hashtable newPlayer = new Hashtable ();
			newPlayer.Add ("number", x+1);
			newPlayer.Add ("material", flags[x]);
			players.Insert (x, newPlayer);
		}
	}

	public static void UpdateCurrentPlayer(){
		if ((currentPlayer + 1) > numPlayers)
			currentPlayer = 0;
		else
			currentPlayer += 1;
	}

	public static Hashtable GetCurrentPlayer(){
		string comb = string.Join (",", players.ToArray ());
		Debug.Log (comb);

		Debug.Log (currentPlayer);
		return players[currentPlayer];
	}
}
