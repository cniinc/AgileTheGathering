using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public enum playerType {none, AgileCoach, TechLead, DesignLead, ProductManager};
	public playerType thisPlayersRole;

	public string PlayersName;


	// Use this for initialization
	void Start () {
		addSelfToPlayerList();	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void addSelfToPlayerList()
	{
		//GameManagerScript.Instance.playerList.Add(this);
		GameManagerScript.GM.playerList.Add(this);
	}
}
