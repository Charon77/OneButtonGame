using UnityEngine;
using System.Collections;

public class Moveable : MonoBehaviour {

	Vector3 destPos;

	float lastXChange = 0;

	void Start() {
		destPos = gameObject.transform.localPosition;
	}

	void Update() {
		gameObject.transform.localPosition = Vector3.Lerp(gameObject.transform.localPosition, destPos, Time.deltaTime);
	}

	public void GoRight(float x)
	{
		//gameObject.transform.Translate(new Vector3(-x,0,0));
		destPos = gameObject.transform.localPosition + new Vector3(-x,0,0);
		lastXChange = -x;
	}

	public void blinkToPos (Vector3 _pos)
	{
		gameObject.transform.localPosition = _pos;
		destPos = _pos + new Vector3 (lastXChange, 0, 0);
	}
}
