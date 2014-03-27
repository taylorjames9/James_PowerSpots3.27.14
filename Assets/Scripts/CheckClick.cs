using UnityEngine;
using System.Collections;

public class CheckClick : MonoBehaviour {

	//private Animator expand;


	public static bool pressedASpot;

	// Use this for initialization
	void Start () {
		Debug.Log ("GameObject initialized");
		//expand = this.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
	
		switch (gameObject.name) {
		case "Dot":
			if (PassScript.passedQuiz1) {
				animation ["Expand"].wrapMode = WrapMode.PingPong;
				animation.Play ("Expand");
				Debug.Log ("MouseClick detected");
			} 
			break;
		default:
			break;
		}
	}

	void OnMouseDown () {

		pressedASpot = true;

		//animation ["Expand"].wrapMode = WrapMode.PingPong;
		//animation.Play ("Expand");
		//Debug.Log ("MouseClick detected");
	}
}
