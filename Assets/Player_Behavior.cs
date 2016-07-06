using UnityEngine;
using System.Collections;

public class Player_Behavior : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	
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
