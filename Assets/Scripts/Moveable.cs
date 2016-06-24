using UnityEngine;
using System.Collections;

public class Moveable : MonoBehaviour {

	Vector3 destPos;
	void Start() {
	}

	void Update() {
	}

	public void GoRight(float x)
	{
		gameObject.transform.Translate(new Vector3(-x,0,0));
	}

	public void blinkToPos (Vector3 _pos)
	{
		gameObject.transform.localPosition = _pos;
	}
}
