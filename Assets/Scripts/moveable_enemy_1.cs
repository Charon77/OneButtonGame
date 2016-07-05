using UnityEngine;
using System.Collections;

public class moveable_enemy_1 : MonoBehaviour {

	Vector3 destPos;

	float speedStepMultiplier = 10.0f;
	void Start() {
		destPos = gameObject.transform.localPosition;
	}

	void Update() {
		gameObject.transform.localPosition = Vector3.Lerp(gameObject.transform.localPosition, destPos, speedStepMultiplier * Time.deltaTime);
		GoLeft (1);
		if (gameObject.transform.position.x < -17) {
			Destroy (gameObject);
		}
	}

	private void GoLeft(float x)
	{
		//gameObject.transform.Translate(new Vector3(-x,0,0));
		destPos = gameObject.transform.localPosition + new Vector3(-x,0,0);

	}

}
