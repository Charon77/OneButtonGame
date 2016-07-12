using UnityEngine;
using System.Collections;

public class CostumerBehavior : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D(Collider2D coll) {
		if (coll.gameObject.tag == "Enemy_3"||coll.gameObject.tag == "Decor" ||coll.gameObject.tag == "Costumer" ) {
			Destroy (gameObject);
			//Debug.Log ("Decor Kena ENEMY");
		}

	}

	void OnTriggerStay2D(Collider2D coll) {
		if (coll.gameObject.tag == "Enemy_3"||coll.gameObject.tag == "Decor" ||coll.gameObject.tag == "Costumer" ) {
			Destroy (gameObject);
			//Debug.Log ("Decor Kena ENEMY");
		}

	}
}
