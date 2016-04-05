using UnityEngine;
using System.Collections;

[System.Serializable]
public class JSONCard : MonoBehaviour {

	public int id;
	public string card_type;
	public string situation;
	public string choice_1;
	public int c1_agile_coach_points;
	public int c1_tech_anchor_points;
	public int c1_product_owner_points;
	public int c1_design_lead_points;
	public int c1_health_impact;
	public int c1_special_event;
	public string c1_agile_coach_explanation;
	public string c1_tech_anchor_explanation;
	public string c1_product_owner_explanation;
	public string c1_design_lead_explanation;
	public string choice_2;
	public int c2_agile_coach_points;
	public int c2_tech_anchor_points;
	public int c2_product_owner_points;
	public int c2_design_lead_points;
	public int c2_health_impact;
	public int c2_special_event;
	public string c2_agile_coach_explanation;
	public string c2_tech_anchor_explanation;
	public string c2_product_owner_explanation;
	public string c2_design_lead_explanation;
	public string choice_3;
	public int c3_agile_coach_points;
	public int c3_tech_anchor_points;
	public int c3_product_owner_points;
	public int c3_design_lead_points;
	public int c3_health_impact;
	public int c3_special_event;
	public string c3_agile_coach_explanation;
	public string c3_tech_anchor_explanation;
	public string c3_product_owner_explanation;
	public string c3_design_lead_explanation;
	public string url;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void CreateCardObject()
	{
		print ("would create card number " + id);
	}



}
