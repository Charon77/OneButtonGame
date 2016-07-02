using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	[SerializeField]
	GameObject playerCharacter;
	// Use this for initialization
	void Start () {
		// Set camera aspect ratio
		Camera.main.aspect = 16f/9f;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void GoRight()
	{		
		foreach (var moveable in GameObject.FindObjectsOfType<Moveable>()) {
			moveable.GoRight(1);
		}

		//playerCharacter.GetComponent<AnimStepper>().Step();
		foreach (var animStepper in playerCharacter.GetComponentsInChildren<AnimStepper>()) {
			animStepper.Step();
		}
		//playerCharacter.GetComponentInChildren<AnimStepper>().Step();


	}
}
