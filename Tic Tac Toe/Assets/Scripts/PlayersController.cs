using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayersController : MonoBehaviour {

	public Material[] flags;
	public static int numPlayers;
	public static List<Hashtable> players;

	private static int currentPlayer;

	void Start () {
		currentPlayer = 0;
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

	public static void UpdateCurrentPlayer(){
		if ((currentPlayer + 1) > numPlayers)
			currentPlayer = 1;
		else
			currentPlayer += 1;
	}

	public static Hashtable GetCurrentPlayer(){
		return players[currentPlayer];
	}
}
