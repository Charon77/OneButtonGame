using UnityEngine;
using System.Collections;

public class DecorBehavior : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnTriggerEnter2D(Collider2D coll) {
		if (coll.gameObject.tag == "Enemy"||coll.gameObject.tag == "Decor") {
			Destroy (gameObject);
			//Debug.Log ("Decor Kena ENEMY");
		}

	}
	void OnTriggerStay2D(Collider2D coll) {
		if (coll.gameObject.tag == "Enemy") {
			//Debug.Log ("Decor Kena ENEMY STAY");
			}

	}
}
