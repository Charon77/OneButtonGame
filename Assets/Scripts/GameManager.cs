using UnityEngine;
using System.Collections;
using HelperStuffs;
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
		foreach (var moveable in Helper.getMoveables()) {
			moveable.GoRight(1);
		}

		//playerCharacter.GetComponent<AnimStepper>().Step();

		playerCharacter.GetComponent<PlayerBehavior>().Step();

		//playerCharacter.GetComponentInChildren<AnimStepper>().Step();


	}
}
