using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Spawner : MonoBehaviour {

	float ymax = 10.24F;
	float xmax = 7.68F;
	int dotmax = 15;
	float yrand;
	float xrand;
	public GameObject dot;
	public List<GameObject> dotList = new List<GameObject> ();

	// Use this for initialization
	void Start () {
	
		for (int x = 0; x<dotmax; x++) {
			yrand = Random.Range (0, ymax) - 5.12F;
			xrand = Random.Range (0, xmax) - 3.68F;
			Instantiate (dot, new Vector3 (xrand, yrand, 0), Quaternion.identity);
			dotList.Add (dot);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}


}
