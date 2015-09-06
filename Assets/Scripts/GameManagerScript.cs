using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManagerScript : MonoBehaviour {

	public int currentDay;
	public List<Player> playerList; 

	public enum stateMachine {none, tutorial, decisionStage, workStage};
	public stateMachine currentState;
	public bool testMode;
	public bool debugMode;

	public static GameManagerScript GM {get; private set;}

	//testObjects
	TestGMScript GMTest;


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
