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
		// Persists on scene change
		DontDestroyOnLoad(this); 
		// Set camera aspect ratio
		Camera.main.aspect = 16f/9f;

		// Inits
		_score = 0;

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void GoRight()
	{		
		// Cancels if Game over
		if (PlayerBehavior.Gameover)
			return;

		float speed = playerCharacter.GetComponent<PlayerBehavior> ().HideTimer;
		speed = Mathf.Max (speed, 0.0f);
		speed = speed * 3.0f / 0.3f;
		speed = speed + 1;

		// 0..4
		foreach (var moveable in Helper.getMoveables()) {
			moveable.GoRight(speed);
		}

		//playerCharacter.GetComponent<AnimStepper>().Step();

		playerCharacter.GetComponent<PlayerBehavior>().Step();

		//playerCharacter.GetComponentInChildren<AnimStepper>().Step();
		_score += (int)(SCORE_MULTIPLIER * MOVEMENT_SCORE*speed);

	}

	public void ResetMultiplier()
	{
		SCORE_MULTIPLIER = 1.0f ;
	}

	public void CustomerHit()
	{
		_score += (int)(SCORE_MULTIPLIER * SELL_SCORE);
	}

	public void Kill()
	{
		Destroy(gameObject);
	}

	public void NotifyHighScore()
	{
		const string HIGH_SCORE = "HIGH_SCORE";
		int lastHighScore;
		// Checks current high score

		// if doesn't exist or higher
		if(!PlayerPrefs.HasKey(HIGH_SCORE) || Score > (lastHighScore = PlayerPrefs.GetInt(HIGH_SCORE)) )
		{
			Debug.Assert(lastHighScore>=0); // just to make sure

			//No High score or higher, setting to my score
			PlayerPrefs.SetInt(HIGH_SCORE, Score);
			// (was lastHighScore)

			///Do Victory Dance(?)
			Debug.Log("New High Score: " + Score);

			// Done here.
			return;
		}
		// Normal stuffs

		Debug.Log("I have seen better: " + lastHighScore);

	}
}
