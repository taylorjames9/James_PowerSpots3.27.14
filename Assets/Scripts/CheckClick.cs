using UnityEngine;
using System.Collections;

public class CheckClick : MonoBehaviour {

	//private Animator expand;


		//public static bool pressedASpot;



		public static bool pressedSpot1_OnDeck;
		public static bool pressedSpot2_OnDeck;
		public static bool pressedSpot3_OnDeck;
		public static bool pressedSpot4_OnDeck;
		public static bool pressedSpot5_OnDeck;
		public static bool pressedSpot6_OnDeck;
		public static bool pressedSpot7_OnDeck;
		public static bool pressedSpot8_OnDeck;
		public static bool pressedSpot9_OnDeck;
		public static bool pressedSpot10_OnDeck;
		public static bool pressedSpot11_OnDeck;
		public static bool pressedSpot12_OnDeck;

		public int quizScore;


	// Use this for initialization
	void Start () {
		Debug.Log ("GameObject initialized");
		//expand = this.GetComponent<Animator> ();
				quizScore = 3;
	}
	
	// Update is called once per frame
	void Update () {
	
		switch (gameObject.name) {
				case "Dot1":
						if (PassScript.passedQuiz1) {
								StartCoroutine(ExpandDot());
						} 
						break;
				case "Dot2":
						if (PassScript.passedQuiz2) {
								StartCoroutine(ExpandDot());
						} 
						break;
				case "Dot3":
						if (PassScript.passedQuiz3) {
								StartCoroutine(ExpandDot());
						} 
						break;
				case "Dot4":
						if (PassScript.passedQuiz4) {
								StartCoroutine(ExpandDot());
						} 
						break;
				case "Dot5":
						if (PassScript.passedQuiz5) {
								StartCoroutine(ExpandDot());
						} 
						break;
				case "Dot6":
						if (PassScript.passedQuiz6) {
								StartCoroutine(ExpandDot());
						} 
						break;
				case "Dot7":
						if (PassScript.passedQuiz7) {
								StartCoroutine(ExpandDot());
						} 
						break;
				case "Dot8":
						if (PassScript.passedQuiz8) {
								StartCoroutine(ExpandDot());
						} 
						break;
				case "Dot9":
						if (PassScript.passedQuiz9) {
								StartCoroutine(ExpandDot());
						} 
						break;
				case "Dot10":
						if (PassScript.passedQuiz10) {
								StartCoroutine(ExpandDot());
						} 
						break;
				case "Dot11":
						if (PassScript.passedQuiz11) {
								StartCoroutine(ExpandDot());
						} 
						break;
				case "Dot12":
						if (PassScript.passedQuiz12) {
								StartCoroutine(ExpandDot());
						} 
						break;
				default:
				break;
		}
	}

	void OnMouseDown () {

				//pressedASpot = true;
				switch (gameObject.name) {
				case "Dot1":
						pressedSpot1_OnDeck = true;
						break;
				case "Dot2":
						pressedSpot2_OnDeck = true;
						break;
				case "Dot3":
						pressedSpot3_OnDeck = true; 
						break;
				case "Dot4":
						pressedSpot4_OnDeck = true;
						break;
				case "Dot5":
						pressedSpot5_OnDeck = true;
						break;
				case "Dot6":
						pressedSpot6_OnDeck = true;
						break;
				case "Dot7":
						pressedSpot7_OnDeck = true;
						break;
				case "Dot8":
						pressedSpot8_OnDeck = true;
						break;
				case "Dot9":
						pressedSpot9_OnDeck = true;
						break;
				case "Dot10":
						pressedSpot10_OnDeck = true;
						break;
				case "Dot11":
						pressedSpot11_OnDeck = true;
						break;
				case "Dot12":
						pressedSpot12_OnDeck = true;
						break;
				default:
						break;
				}
	}

		public IEnumerator ExpandDot(){

				float randomWait; 
				randomWait = Random.Range (0, 5);
				print ("randomWait" +randomWait);

				//animation ["Expand"].wrapMode = WrapMode.Loop;
				//animation.Play ("Expand");

				if(transform.localScale.x < quizScore){
						transform.localScale += new Vector3 (0.05F, 0.05f, 0.05f);
						//transform.localScale.y += 0.05F;
				}else if(transform.localScale.x >= quizScore){
						transform.localScale = new Vector3 (0.1f, 0.1f, 0.1f);
				}
				yield return new WaitForSeconds (randomWait);

		}
}
