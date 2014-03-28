using UnityEngine;
using System.Collections;

public class takeQuizBTN : MonoBehaviour {


		public TextMesh takeWhichQuizTXT; 

	// Use this for initialization
	void Start () {

		gameObject.renderer.enabled = false;
	
	}
	
	// Update is called once per frame
	void Update () {
		if (CheckClick.pressedSpot1_OnDeck || CheckClick.pressedSpot2_OnDeck || CheckClick.pressedSpot3_OnDeck || CheckClick.pressedSpot4_OnDeck || CheckClick.pressedSpot5_OnDeck || CheckClick.pressedSpot6_OnDeck || CheckClick.pressedSpot7_OnDeck || CheckClick.pressedSpot8_OnDeck || CheckClick.pressedSpot9_OnDeck || CheckClick.pressedSpot10_OnDeck || CheckClick.pressedSpot11_OnDeck || CheckClick.pressedSpot12_OnDeck) {
			gameObject.renderer.enabled = true;
		} else {
			gameObject.renderer.enabled = false;
		}
	}
}
