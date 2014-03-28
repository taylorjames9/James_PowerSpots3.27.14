using UnityEngine;
using System.Collections;

public class NoBtnScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (CheckClick.pressedSpot1_OnDeck || CheckClick.pressedSpot2_OnDeck || CheckClick.pressedSpot3_OnDeck || CheckClick.pressedSpot4_OnDeck || CheckClick.pressedSpot5_OnDeck || CheckClick.pressedSpot6_OnDeck || CheckClick.pressedSpot7_OnDeck || CheckClick.pressedSpot8_OnDeck || CheckClick.pressedSpot9_OnDeck || CheckClick.pressedSpot10_OnDeck || CheckClick.pressedSpot11_OnDeck || CheckClick.pressedSpot12_OnDeck) {
			gameObject.renderer.enabled = true;
		} else {
			gameObject.renderer.enabled = false;
		}
	
	}

	void OnMouseDown(){
				//CheckClick.pressedASpot = false;
				if (CheckClick.pressedSpot1_OnDeck) {
						CheckClick.pressedSpot1_OnDeck = !CheckClick.pressedSpot1_OnDeck;
				} else if (CheckClick.pressedSpot2_OnDeck) {
						CheckClick.pressedSpot2_OnDeck = !CheckClick.pressedSpot2_OnDeck;
				} else if (CheckClick.pressedSpot3_OnDeck) {
						CheckClick.pressedSpot3_OnDeck = !CheckClick.pressedSpot3_OnDeck;
				} else if (CheckClick.pressedSpot4_OnDeck) {
						CheckClick.pressedSpot4_OnDeck = !CheckClick.pressedSpot4_OnDeck;
				} else if (CheckClick.pressedSpot5_OnDeck) {
						CheckClick.pressedSpot5_OnDeck = !CheckClick.pressedSpot5_OnDeck;
				} else if (CheckClick.pressedSpot6_OnDeck) {
						CheckClick.pressedSpot6_OnDeck = !CheckClick.pressedSpot6_OnDeck;
				} else if (CheckClick.pressedSpot7_OnDeck) {
						CheckClick.pressedSpot7_OnDeck= !CheckClick.pressedSpot7_OnDeck;
				} else if (CheckClick.pressedSpot8_OnDeck) {
						CheckClick.pressedSpot8_OnDeck= !CheckClick.pressedSpot8_OnDeck;
				} else if (CheckClick.pressedSpot9_OnDeck) {
						CheckClick.pressedSpot9_OnDeck= !CheckClick.pressedSpot9_OnDeck;
				} else if (CheckClick.pressedSpot10_OnDeck) {
						CheckClick.pressedSpot10_OnDeck= !CheckClick.pressedSpot10_OnDeck;
				} else if (CheckClick.pressedSpot11_OnDeck) {
						CheckClick.pressedSpot11_OnDeck= !CheckClick.pressedSpot11_OnDeck;
				} else if (CheckClick.pressedSpot12_OnDeck) {
						CheckClick.pressedSpot12_OnDeck= !CheckClick.pressedSpot12_OnDeck;
				}
	}
}
