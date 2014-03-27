using UnityEngine;
using System.Collections;

public class PassScript : MonoBehaviour {

	public static bool passedQuiz1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown(){

		passedQuiz1 = true; 
		CheckClick.pressedASpot = false;
		Application.LoadLevel ("ExpandingMap"); 

	}
}
