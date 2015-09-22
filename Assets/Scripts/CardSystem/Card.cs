﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Card : MonoBehaviour {

	public bool testCard;
	public enum cardType {none, choiceCard, eventCard, featureCard, boosterCard, goodPracticeCard};
	public cardType myCardType;

	public FrontCard myFront;
	public BackCard myBack; 


	// Use this for initialization
	void Start () {

		if(testCard)
		{
			runTestCard();
		}
		else selectCard();
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	void selectCard()
	{

	}

	void runTestCard()
	{
		myFront.testPopulateFront();
		myBack.testPopulateBack();
	}

	public void flipCard()
	{
		if(myFront.gameObject.activeSelf)
		{
			myFront.gameObject.SetActive(false);
			myBack.gameObject.SetActive(true);
		}
		else 
		{
			myFront.gameObject.SetActive(true);
			myBack.gameObject.SetActive(false);
		}
	}
}
