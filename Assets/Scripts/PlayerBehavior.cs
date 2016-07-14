using UnityEngine;
using System.Collections;
using HelperStuffs;

public class PlayerBehavior : MonoBehaviour {

	public float timeToHide = 1.0f;
	[SerializeField] GameObject LoseSound;
	float hideTimer;
	public static bool Gameover; //klo gameover smua berhenti, input dan enemy_1 kena akses ini

	[SerializeField] Sprite hideSprite;

	// Use this for initialization
	void Start () {
		Gameover = false;
		hideTimer = timeToHide;
	}
	
	// Update is called once per frame
	void Update () {
		
		if (hideTimer > 0)
		{
			hideTimer -= Time.deltaTime;
			GetComponent<AudioSource> ().UnPause ();
		}
		else
		{
			GetComponent<AudioSource> ().Pause ();
			if (!Gameover) {
				
				Hide ();
			}
		}
	}

	void Hide()
	{
		gameObject.GetComponent<SpriteRenderer>().sprite = hideSprite;

		// Hide all children
		for (int i=0; i<gameObject.transform.childCount; i++)
		{
			gameObject.transform.GetChild(i).gameObject.GetComponent<SpriteRenderer>().sprite=null;
		}



	}

	public void Step() {
		hideTimer = timeToHide;

		foreach (var animStepper in gameObject.GetComponentsInChildren<AnimStepper>()) {
			animStepper.Step();
		}
	}

	//tag Enemy_1 muncu karena kalau pke tag enemy menghancurkan smua decor kalau kena 
	void OnTriggerEnter2D(Collider2D coll) {
		if (coll.gameObject.tag == "Enemy" || coll.gameObject.tag == "Enemy_1" |coll.gameObject.tag=="Enemy_3") {
			Debug.Log ("GAME OVER ENTER");
			Gameover = true;
			Instantiate (LoseSound);

		}


	}
	void OnTriggerStay2D(Collider2D coll) {
		if (coll.gameObject.tag == "Enemy"|| coll.gameObject.tag == "Enemy_1") {
			//Debug.Log ("GAME OVER STAY");
		}

	}
}
