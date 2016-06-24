using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		/// TODO: Put outside Update?
		if(Input.GetKeyUp(KeyCode.Space))
		{
			GameObject.FindObjectOfType<GameManager>().GoRight();
		}
	}
}
