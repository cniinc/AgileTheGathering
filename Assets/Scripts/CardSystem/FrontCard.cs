using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FrontCard : MonoBehaviour {


	public Text cardTypeTextBox;
	public Text eventDescriptionBox;
	public Text choicesTextBox;
	public Text option1Box;
	public Text option2Box;
	public Text option3Box;


	//test variables
	string testCardTypeText = "Choice";
	string testEventDescriptorText = "Your CEO decides this is now a pet walking service for hamsters.";
	bool testDisplayChoicesBool = true;
	string testOption1Text = "say 'sure!'";
	string testOption2Text = "say 'I quit!'";
	string testOption3Text = "";

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void testPopulateFront()
	{
		populateTextBoxes(testCardTypeText, testEventDescriptorText, testDisplayChoicesBool, testOption1Text, testOption2Text, testOption3Text);
	}

	void populateTextBoxes(string myCardTypeText, string myEventDescriptorText, bool myDisplayChoices, string myOption1Text, string myOption2Text, string myOption3Text)
	{
		cardTypeTextBox.text = myCardTypeText;
		eventDescriptionBox.text = myEventDescriptorText;
		if(myDisplayChoices)
			choicesTextBox.enabled = true;
		if(!myDisplayChoices)
			choicesTextBox.enabled = false;
		option1Box.text = myOption1Text;
		option2Box.text = myOption2Text;
		option3Box.text = myOption3Text;
	}
}
