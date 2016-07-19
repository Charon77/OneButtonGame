using UnityEngine;
using System.Collections;
using HelperStuffs;

public class CostumerBehavior : MonoBehaviour {


	Animator anim;

	// Use this for initialization
	void Start () {
		
		anim = this.GetComponent<Animator> ();

	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D(Collider2D coll) {
		if (coll.gameObject.tag == "Enemy_3" ||coll.gameObject.tag == "Costumer" ) {
			Destroy (gameObject);
			//Debug.Log ("Decor Kena ENEMY");
		}
		else if (coll.gameObject.tag == "Player" ) {
			Helper.getGameManager().CustomerHit();
			anim.SetBool ("Player", true);
			GetComponent<AudioSource> ().Play ();
			GetComponentInChildren<AnimStepper> ().Step ();
			GetComponent<BoxCollider2D> ().enabled = false;
		}
	}

	void OnTriggerStay2D(Collider2D coll) {
		if (coll.gameObject.tag == "Enemy_3"||coll.gameObject.tag == "Costumer" ) {
			Destroy (gameObject);
			//Debug.Log ("Decor Kena ENEMY");
		}

	}
}
