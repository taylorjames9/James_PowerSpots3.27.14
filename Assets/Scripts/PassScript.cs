using UnityEngine;
using System.Collections;

public class PassScript : MonoBehaviour {

	
		public static bool passedQuiz1;
		public static bool passedQuiz2;
		public static bool passedQuiz3;
		public static bool passedQuiz4;
		public static bool passedQuiz5;
		public static bool passedQuiz6;
		public static bool passedQuiz7;
		public static bool passedQuiz8;
		public static bool passedQuiz9;
		public static bool passedQuiz10;
		public static bool passedQuiz11;
		public static bool passedQuiz12;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown(){
		
				//write a switch statement for if the sceneName corresponding to quiz name

		switch(Application.loadedLevelName){
				case "TestQuiz":
						passedQuiz1 = true; 
						CheckClick.pressedSpot1_OnDeck = false;
						Application.LoadLevel ("ExpandingMap"); 
						break;
				case "TestQuiz2":
						passedQuiz2 = true; 
						CheckClick.pressedSpot2_OnDeck = false;
						Application.LoadLevel ("ExpandingMap"); 
						break;
				case "TestQuiz3":
						passedQuiz3 = true; 
						CheckClick.pressedSpot3_OnDeck = false;
						Application.LoadLevel ("ExpandingMap"); 
						break;
				case "TestQuiz4":
						passedQuiz4 = true; 
						CheckClick.pressedSpot4_OnDeck = false;
						Application.LoadLevel ("ExpandingMap"); 
						break;
				case "TestQuiz5":
						passedQuiz5 = true; 
						CheckClick.pressedSpot5_OnDeck = false;
						Application.LoadLevel ("ExpandingMap"); 
						break;
				case "TestQuiz6":
						passedQuiz6 = true; 
						CheckClick.pressedSpot6_OnDeck = false;
						Application.LoadLevel ("ExpandingMap"); 
						break;
				case "TestQuiz7":
						passedQuiz7 = true; 
						CheckClick.pressedSpot7_OnDeck = false;
						Application.LoadLevel ("ExpandingMap"); 
						break;
				case "TestQuiz8":
						passedQuiz8 = true; 
						CheckClick.pressedSpot8_OnDeck = false;
						Application.LoadLevel ("ExpandingMap"); 
						break;
				case "TestQuiz9":
						passedQuiz9 = true; 
						CheckClick.pressedSpot9_OnDeck = false;
						Application.LoadLevel ("ExpandingMap"); 
						break;
				case "TestQuiz10":
						passedQuiz10 = true; 
						CheckClick.pressedSpot10_OnDeck = false;
						Application.LoadLevel ("ExpandingMap"); 
						break;
				case "TestQuiz11":
						passedQuiz11 = true; 
						CheckClick.pressedSpot11_OnDeck = false;
						Application.LoadLevel ("ExpandingMap"); 
						break;
				case "TestQuiz12":
						passedQuiz12 = true; 
						CheckClick.pressedSpot12_OnDeck = false;
						Application.LoadLevel ("ExpandingMap"); 
						break;
				default:
						break;
	}
}
}
