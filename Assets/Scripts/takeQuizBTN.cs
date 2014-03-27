using UnityEngine;
using System.Collections;

public class takeQuizBTN : MonoBehaviour {


	// Use this for initialization
	void Start () {

		gameObject.renderer.enabled = false;
	
	}
	
	// Update is called once per frame
	void Update () {

		print ("CheckClick.pressedASpot" +CheckClick.pressedASpot);
		if (CheckClick.pressedASpot) {
			//gameObject.transform.position = new Vector2(
			gameObject.renderer.enabled = true;
		} else {
			gameObject.renderer.enabled = false;
		}
	}
}
