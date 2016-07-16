using UnityEngine;
using System.Collections;
using HelperStuffs;

public class GameOverManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log("Game over :D");
		Helper.getGameManager().NotifyHighScore();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
