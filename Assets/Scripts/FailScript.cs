using UnityEngine;
using System.Collections;

public class FailScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown(){
				//CheckClick.pressedASpot = false;

				switch (Application.loadedLevelName) {
				case "TestQuiz":
						CheckClick.pressedSpot1_OnDeck = false;
						break;
				case "TestQuiz2":
						CheckClick.pressedSpot2_OnDeck = false;
						break;
				case "TestQuiz3":
						CheckClick.pressedSpot3_OnDeck = false;
						break;
				case "TestQuiz4":
						CheckClick.pressedSpot4_OnDeck = false;
						break;
				case "TestQuiz5":
						CheckClick.pressedSpot5_OnDeck = false;
						break;
				case "TestQuiz6":
						CheckClick.pressedSpot6_OnDeck = false;
						break;
				case "TestQuiz7":
						CheckClick.pressedSpot7_OnDeck = false;
						break;
				case "TestQuiz8":
						CheckClick.pressedSpot8_OnDeck = false;
						break;
				case "TestQuiz9":
						CheckClick.pressedSpot9_OnDeck = false;
						break;
				case "TestQuiz10":
						CheckClick.pressedSpot10_OnDeck = false;
						break;
				case "TestQuiz11":
						CheckClick.pressedSpot11_OnDeck = false;
						break;
				case "TestQuiz12":
						CheckClick.pressedSpot12_OnDeck = false;
						break;
				default:
						break;
		
				}
				Application.LoadLevel ("ExpandingMap"); 

	}

}
