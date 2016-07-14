using UnityEngine;
using System.Collections;

public class MoveableEnemy1 : MonoBehaviour {

	Vector3 destPos;
	float speedStepMultiplier = 10.0f;
	void Start() {
		destPos = gameObject.transform.localPosition;
	}

	void Update() {
		if (PlayerBehavior.Gameover) {
			//mau ksi animasi or something
		} else {
			gameObject.transform.localPosition = Vector3.Lerp (gameObject.transform.localPosition, destPos, speedStepMultiplier * Time.deltaTime);
			GoLeft (1);
			if (gameObject.transform.position.x < -17) {
				Destroy (gameObject);
		
			}
		}
	}

	private void GoLeft(float x)
	{
		//gameObject.transform.Translate(new Vector3(-x,0,0));
		destPos = gameObject.transform.localPosition + new Vector3(-x,0,0);

	}
	void OnTriggerEnter2D(Collider2D coll) {
		if (coll.gameObject.tag == "Player" ) {
			
			//Debug.Log ("Decor Kena ENEMY");
		}

	}



}
