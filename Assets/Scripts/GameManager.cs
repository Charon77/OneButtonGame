using UnityEngine;
using System.Collections;
using HelperStuffs;
public class GameManager : MonoBehaviour {

	[SerializeField]
	GameObject playerCharacter;

	[SerializeField]
	int MOVEMENT_SCORE;

	[SerializeField]
	int SELL_SCORE;

	[SerializeField]
	float SCORE_MULTIPLIER = 1.0f;

	public int Score {
		get{
			return _score;	
		}
	}

	private int _score;

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
		// Cancels if Game over
		if (PlayerBehavior.Gameover)
			return;
		
		foreach (var moveable in Helper.getMoveables()) {
			moveable.GoRight(1);
		}

		//playerCharacter.GetComponent<AnimStepper>().Step();

		playerCharacter.GetComponent<PlayerBehavior>().Step();

		//playerCharacter.GetComponentInChildren<AnimStepper>().Step();
		_score += (int)(SCORE_MULTIPLIER * MOVEMENT_SCORE);

	}

	public void ResetMultiplier()
	{
		SCORE_MULTIPLIER = 1.0f ;
	}

	public void CustomerHit()
	{
		_score += (int)(SCORE_MULTIPLIER * SELL_SCORE);
	}
}
