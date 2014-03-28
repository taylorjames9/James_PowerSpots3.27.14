using UnityEngine;
using System.Collections;

public class YesBtnScript : MonoBehaviour {

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
				if (CheckClick.pressedSpot1_OnDeck) {
						Application.LoadLevel ("TestQuiz");
				} else if (CheckClick.pressedSpot2_OnDeck) {
						Application.LoadLevel ("TestQuiz2");
				} else if (CheckClick.pressedSpot3_OnDeck) {
						Application.LoadLevel ("TestQuiz3");
				} else if (CheckClick.pressedSpot4_OnDeck) {
						Application.LoadLevel ("TestQuiz4");
				} else if (CheckClick.pressedSpot5_OnDeck) {
						Application.LoadLevel ("TestQuiz5");
				} else if (CheckClick.pressedSpot6_OnDeck) {
						Application.LoadLevel ("TestQuiz6");
				} else if (CheckClick.pressedSpot7_OnDeck) {
						Application.LoadLevel ("TestQuiz7");
				} else if (CheckClick.pressedSpot8_OnDeck) {
						Application.LoadLevel ("TestQuiz8");
				} else if (CheckClick.pressedSpot9_OnDeck) {
						Application.LoadLevel ("TestQuiz9");
				} else if (CheckClick.pressedSpot10_OnDeck) {
						Application.LoadLevel ("TestQuiz10");
				} else if (CheckClick.pressedSpot11_OnDeck) {
						Application.LoadLevel ("TestQuiz11");
				} else if (CheckClick.pressedSpot12_OnDeck) {
						Application.LoadLevel ("TestQuiz12");
				}
		}
}
