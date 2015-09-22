using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BackCard : MonoBehaviour {

	public Text EventDescriptionBox;
	public Text choice1Descriptor;
	public Text choice1Fallout;
	public Text c1_PM_Result;
	public Text c1_AC_Result;
	public Text c1_DL_Result;
	public Text c1_TA_Result;
	public Text choice2Descriptor;
	public Text choice2Fallout;
	public Text c2_PM_Result;
	public Text c2_AC_Result;
	public Text c2_DL_Result;
	public Text c2_TA_Result;
	public Text choice3Descriptor;
	public Text choice3Fallout;
	public Text c3_PM_Result;
	public Text c3_AC_Result;
	public Text c3_DL_Result;
	public Text c3_TA_Result;


	//test variables
	string test_EventDescriptionText = "CEO decides this is now a pet walking service for hamsters.";
	string test_Choice1DescriptorText = "Say 'Sure!'";
	string test_choice1FalloutText = "Everyone puts 4 sweat because they're out of a job.";
	string test_C1_PM_ResultText = "PM: 4";
	string test_C1_AC_ResultText = "AC: 4";
	string test_C1_DL_ResultText = "DL: 4";
	string test_C1_TA_ResultText = "TA: 4";
	string test_Choice2DescriptorText = "Say 'No Way!'";
	string test_Choice2FalloutText = "You're all fired. But no sweat!";
	string test_C2_PM_ResultText = "PM: 0";
	string test_C2_AC_ResultText = "AC: 0";
	string test_C2_DL_ResultText = "DL: 0";
	string test_C2_TA_ResultText = "TA: 0";
	string test_Choice3DescriptorText = "";
	string test_Choice3FalloutText = "";
	string test_C3_PM_ResultText;
	string test_C3_AC_ResultText = "";
	string test_C3_DL_ResultText = "";
	string test_C3_TA_ResultText = "";



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void testPopulateBack()
	{ populateTextBoxes(	test_EventDescriptionText, 
		                    test_Choice1DescriptorText, 
		                    test_choice1FalloutText, 
		                    test_C1_PM_ResultText, 
		                    test_C1_AC_ResultText, 
		                    test_C1_DL_ResultText, 
		                    test_C1_TA_ResultText, 
		                    test_Choice2DescriptorText,
		                    test_Choice2FalloutText,
		                    test_C2_PM_ResultText,
		                    test_C2_AC_ResultText,
		                    test_C2_DL_ResultText,
		                    test_C2_TA_ResultText,
		                    test_Choice3DescriptorText,
		                    test_Choice3FalloutText,
		                    test_C3_PM_ResultText,
		                    test_C3_AC_ResultText,
		                    test_C3_DL_ResultText,
		                    test_C3_TA_ResultText);
	}

	void populateTextBoxes(string myEventDescriptionText, 
	                       string myChoice1DescriptorText, 
	                       string myChoice1FalloutText, 
	                       string myC1_PM_ResultText, 
	                       string myC1_AC_ResultText, 
	                       string myC1_DL_ResultText, 
	                       string myC1_TA_ResultText, 
	                       string myChoice2DescriptorText,
	                       string myChoice2FalloutText,
	                       string myC2_PM_ResultText,
	                       string myC2_AC_ResultText,
	                       string myC2_DL_ResultText,
	                       string myC2_TA_ResultText,
	                       string myChoice3DescriptorText,
	                       string myChoice3FalloutText,
	                       string myC3_PM_ResultText,
	                       string myC3_AC_ResultText,
	                       string myC3_DL_ResultText,
	                       string myC3_TA_ResultText)
	{
		EventDescriptionBox.text = myEventDescriptionText;
		choice1Descriptor.text = myChoice1DescriptorText;
		choice1Fallout.text = myChoice1FalloutText;
		c1_PM_Result.text = myC1_PM_ResultText;
		c1_AC_Result.text = myC1_AC_ResultText;
		c1_DL_Result.text = myC1_DL_ResultText;
		c1_TA_Result.text = myC1_TA_ResultText;
		choice2Descriptor.text = myChoice2DescriptorText;
		choice2Fallout.text = myChoice2FalloutText;
		c2_PM_Result.text = myC2_PM_ResultText;
		c2_AC_Result.text = myC2_AC_ResultText;
		c2_DL_Result.text = myC2_DL_ResultText;
		c2_TA_Result.text = myC2_TA_ResultText;
		choice3Descriptor.text = myChoice3DescriptorText;
		choice3Fallout.text = myChoice3FalloutText;
		c3_PM_Result.text = myC3_PM_ResultText;
		c3_AC_Result.text = myC3_AC_ResultText;
		c3_DL_Result.text = myC3_DL_ResultText;
		c3_TA_Result.text = myC3_TA_ResultText;
	}
}
