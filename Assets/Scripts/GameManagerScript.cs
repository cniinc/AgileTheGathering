using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManagerScript : MonoBehaviour {

	public int currentDay;
	public List<Player> playerList; 

	public enum stateSystem {none, tutorial, decisionStage, workStage};
	public stateSystem stateMachine;
	public bool testMode;
	public bool debugMode;





	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
