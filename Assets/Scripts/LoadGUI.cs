using UnityEngine;
using System.Collections;

public class LoadGUI : MonoBehaviour {



	// Use this for initialization
	void Start () {

	}

	void OnGUI () {
		if (GUI.Button (new Rect (10, 10, 150, 35), "Stop Animation")) {
			Debug.Log ("Button hit");
			StopAnimation();
		}
	}

	// Update is called once per frame
	void Update () {
	
	}

	void StopAnimation () {
		GameObject[] DotArray = GameObject.FindGameObjectsWithTag ("Respawn");
		foreach (GameObject lDot in DotArray) {
			lDot.animation["Expand"].wrapMode = WrapMode.Once;
		}
	}
}
