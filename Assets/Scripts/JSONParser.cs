using UnityEngine;
using System.Collections;

[System.Serializable]
public class JSONParser : MonoBehaviour {

	public GameObject cardObject;
	public GameObject[] ListOfCards;

	// Use this for initialization
	void Start () {

		//StartCoroutine (PullWholeCardList ());

		/*for (int id = 44; id < 50; id++) {
			print ("ID: " + id);
			StartCoroutine (CreateCardsFromURLs (id));
		} */
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator PullWholeCardList()
	{
		WWW cardList = new WWW ("http://gameschool.herokuapp.com/cards.json");
		yield return cardList;
		print (cardList.text);
		CreateWholeFromJSON (cardList.text);
	}



	public void CreateWholeFromJSON(string cardList)
	{
		JSONCard jCard = JsonUtility.FromJson<JSONCard> (cardList);
		//GameObject card = Instantiate (cardObject, Vector3.zero, Quaternion.identity) as GameObject;
	}



	public IEnumerator CreateCardsFromURLs(int id) 
	{
		
		print ("pulling data of card " + id);
		WWW cardURL = new WWW ("http://gameschool.herokuapp.com/cards/" + id + ".json");
		yield return cardURL;
		print (cardURL.text);
		JSONCard jCard = JsonUtility.FromJson<JSONCard> ("[" + cardURL.text + "]");
		jCard.CreateCardObject ();

		
	}
}
