using UnityEngine;
using System.Collections;

public class NoBtnScript : MonoBehaviour {

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
		CheckClick.pressedASpot = false;


	}

}
