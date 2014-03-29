using UnityEngine;
using System.Collections;

public class QuizTimer : MonoBehaviour {


	public TextMesh timer; 
	float startTime; 
	public static float timeSinceLoad;

	void Awake() {
		timeSinceLoad = 0;
		startTime = Time.time;
	}

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
				timeSinceLoad = Time.time - startTime;
				timer.text = timeSinceLoad.ToString("F1");
	}
}
