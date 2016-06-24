using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void GoRight()
	{		
		foreach (var moveable in GameObject.FindObjectsOfType<Moveable>()) {
			moveable.GoRight(4);
		}
	}
}
