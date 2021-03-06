﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using HelperStuffs;
public class InputManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		// Check Key Up if in PC
		#if UNITY_EDITOR || UNITY_STANDALONE
		/// TODO: Put outside Update?
		if (Input.GetKeyUp (KeyCode.Space)) {
			Helper.getGameManager ().GoRight ();
		}
		if (Input.GetKeyDown (KeyCode.Escape)) {
			SceneManager.LoadScene ("MainMenu");
		}
			
		#else
		// Mobile devices: Use touch screen
		if (Input.GetTouch (0).phase == TouchPhase.Began) {
			Helper.getGameManager ().GoRight ();
		}
		if (Input.GetKeyDown (KeyCode.Escape)) {
		SceneManager.LoadScene ("MainMenu");
		}
		#endif

	}
}
