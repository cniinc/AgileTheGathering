using UnityEngine;
using System.Collections;

public class TestGMScript : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		testForFourPlayers();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void testForFourPlayers()
	{
		if(GameManagerScript.GM.playerList.Count == 4)
		{
			print("4 player test: Success. Number of players: " + GameManagerScript.GM.playerList.Count);
		}
		else Debug.LogError("4 player test: Failed. There are not 4 players in the game!");
	}
}
