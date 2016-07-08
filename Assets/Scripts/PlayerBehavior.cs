using UnityEngine;
using System.Collections;
using HelperStuffs;

public class PlayerBehavior : MonoBehaviour {

	public float timeToHide = 1.0f;

	float hideTimer;

	[SerializeField] Sprite hideSprite;

	// Use this for initialization
	void Start () {
		hideTimer = timeToHide;
	}
	
	// Update is called once per frame
	void Update () {
		if (hideTimer > 0)
		{
			hideTimer -= Time.deltaTime;
		}
		else
		{
			Hide();
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
		if (coll.gameObject.tag == "Enemy" || coll.gameObject.tag == "Enemy_1" ) {
			Debug.Log ("GAME OVER ENTER");
		}
		else if (coll.gameObject.tag == "Costumer" ) {
			Debug.Log ("SCORE NAMBAH");
			Helper.getGameManager().CustomerHit();
		}

	}
	void OnTriggerStay2D(Collider2D coll) {
		if (coll.gameObject.tag == "Enemy"|| coll.gameObject.tag == "Enemy_1") {
			Debug.Log ("GAME OVER STAY");
		}

	}
}
