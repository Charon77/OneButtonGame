using UnityEngine;
using System.Collections;

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

	void OnTriggerEnter2D(Collider2D coll) {
		if (coll.gameObject.tag == "Enemy") {
			Debug.Log ("GAME OVER ENTER");
		}

	}
	void OnTriggerStay2D(Collider2D coll) {
		if (coll.gameObject.tag == "Enemy") {
			Debug.Log ("GAME OVER STAY");
		}

	}
}
