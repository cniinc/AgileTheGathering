using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManagerScript : MonoBehaviour {


	//setup variables
	public static GameManagerScript GM {get; private set;}
	public enum stateMachine {none, tutorial, decisionStage, workStage};
	public bool testMode;
	public bool debugMode;
	public List<Player> playerList; 

	//testing GameObjects
	TestGMScript GMTest;

	//State variables
	public int currentDay;
	public stateMachine currentState;



	void Awake()
	{
		GM = this;
	}

	// Use this for initialization
	void Start () {


		if(testMode) 
			addGMTestScript();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void addGMTestScript()
	{
		GameObject Gmt = (GameObject)Instantiate(Resources.Load("TestPrefabs/GMTest")) as GameObject;
		GMTest = Gmt.GetComponent<TestGMScript>() as TestGMScript;
		GMTest.gameObject.transform.parent = this.gameObject.transform;
	}


}
