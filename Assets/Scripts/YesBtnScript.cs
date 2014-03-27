using UnityEngine;
using System.Collections;

public class YesBtnScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (CheckClick.pressedASpot) {
			gameObject.renderer.enabled = true;
		} else {
			gameObject.renderer.enabled = false;
		}
	
	}

	void OnMouseDown(){
		Application.LoadLevel ("TestQuiz");
	}
}
