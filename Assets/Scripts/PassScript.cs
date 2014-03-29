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

		public static float quizScore1;
		public static float quizScore2;
		public static float quizScore3;
		public static float quizScore4;
		public static float quizScore5;
		public static float quizScore6;
		public static float quizScore7;
		public static float quizScore8;
		public static float quizScore9;
		public static float quizScore10;
		public static float quizScore11;
		public static float quizScore12;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown(){
		
				//write a switch statement for if the sceneName corresponding to quiz name

				//float randomNum = Random.Range (0,2)/5;
		
				switch(Application.loadedLevelName){
				case "TestQuiz":
						passedQuiz1 = true; 
						if (QuizTimer.timeSinceLoad < 10.0f) {
								quizScore1 = 1/QuizTimer.timeSinceLoad; 
						} else {
								quizScore1 = 0.1f; 
						}
						CheckClick.pressedSpot1_OnDeck = false;
						Application.LoadLevel ("ExpandingMap"); 
						break;
				case "TestQuiz2":
						passedQuiz2 = true; 
						if (QuizTimer.timeSinceLoad < 10.0f) {
								quizScore2 = 1/QuizTimer.timeSinceLoad; 
						} else {
								quizScore2 = 0.1f; 
						}
						CheckClick.pressedSpot2_OnDeck = false;
						Application.LoadLevel ("ExpandingMap"); 
						break;
				case "TestQuiz3":
						passedQuiz3 = true; 
						if (QuizTimer.timeSinceLoad < 10.0f) {
								quizScore3 = 1/QuizTimer.timeSinceLoad; 
						} else {
								quizScore3 = 0.1f; 
						}
						CheckClick.pressedSpot3_OnDeck = false;
						Application.LoadLevel ("ExpandingMap"); 
						break;
				case "TestQuiz4":
						passedQuiz4 = true; 
						if (QuizTimer.timeSinceLoad < 10.0f) {
								quizScore4 = 1/QuizTimer.timeSinceLoad; 
						} else {
								quizScore4 = 0.1f; 
						}
						quizScore4 = QuizTimer.timeSinceLoad; 
						CheckClick.pressedSpot4_OnDeck = false;
						Application.LoadLevel ("ExpandingMap"); 
						break;
				case "TestQuiz5":
						passedQuiz5 = true; 
						if (QuizTimer.timeSinceLoad < 10.0f) {
								quizScore5 = 1/QuizTimer.timeSinceLoad; 
						} else {
								quizScore5 = 0.1f; 
						}
						quizScore5 = QuizTimer.timeSinceLoad; 
						CheckClick.pressedSpot5_OnDeck = false;
						Application.LoadLevel ("ExpandingMap"); 
						break;
				case "TestQuiz6":
						passedQuiz6 = true; 
						if (QuizTimer.timeSinceLoad < 10.0f) {
								quizScore6 = 1/QuizTimer.timeSinceLoad; 
						} else {
								quizScore6 = 0.1f; 
						}
						quizScore6 = QuizTimer.timeSinceLoad; 
						CheckClick.pressedSpot6_OnDeck = false;
						Application.LoadLevel ("ExpandingMap"); 
						break;
				case "TestQuiz7":
						passedQuiz7 = true; 
						if (QuizTimer.timeSinceLoad < 10.0f) {
								quizScore7 = 1/QuizTimer.timeSinceLoad; 
						} else {
								quizScore7 = 0.1f; 
						}
						quizScore7 = QuizTimer.timeSinceLoad; 
						CheckClick.pressedSpot7_OnDeck = false;
						Application.LoadLevel ("ExpandingMap"); 
						break;
				case "TestQuiz8":
						passedQuiz8 = true; 
						if (QuizTimer.timeSinceLoad < 10.0f) {
								quizScore8 = 1/QuizTimer.timeSinceLoad; 
						} else {
								quizScore8 = 0.1f; 
						}
						quizScore8 = QuizTimer.timeSinceLoad; 
						CheckClick.pressedSpot8_OnDeck = false;
						Application.LoadLevel ("ExpandingMap"); 
						break;
				case "TestQuiz9":
						passedQuiz9 = true; 
						if (QuizTimer.timeSinceLoad < 10.0f) {
								quizScore9 = 1/QuizTimer.timeSinceLoad; 
						} else {
								quizScore9 = 0.1f; 
						}
						quizScore9 = QuizTimer.timeSinceLoad; 
						CheckClick.pressedSpot9_OnDeck = false;
						Application.LoadLevel ("ExpandingMap"); 
						break;
				case "TestQuiz10":
						if (QuizTimer.timeSinceLoad < 10.0f) {
								quizScore10 = 1/QuizTimer.timeSinceLoad; 
						} else {
								quizScore10 = 0.1f; 
						}
						quizScore10 = QuizTimer.timeSinceLoad; 
						CheckClick.pressedSpot10_OnDeck = false;
						Application.LoadLevel ("ExpandingMap"); 
						break;
				case "TestQuiz11":
						passedQuiz11 = true; 
						if (QuizTimer.timeSinceLoad < 10.0f) {
								quizScore11 = 1/QuizTimer.timeSinceLoad; 
						} else {
								quizScore11 = 0.1f; 
						}
						quizScore11 = QuizTimer.timeSinceLoad; 
						CheckClick.pressedSpot11_OnDeck = false;
						Application.LoadLevel ("ExpandingMap"); 
						break;
				case "TestQuiz12":
						passedQuiz12 = true; 
						if (QuizTimer.timeSinceLoad < 10.0f) {
								quizScore12 = 1/QuizTimer.timeSinceLoad; 
						} else {
								quizScore12 = 0.1f; 
						}
						quizScore12 = QuizTimer.timeSinceLoad; 
						CheckClick.pressedSpot12_OnDeck = false;
						Application.LoadLevel ("ExpandingMap"); 
						break;
				default:
						break;
	}
}
}
