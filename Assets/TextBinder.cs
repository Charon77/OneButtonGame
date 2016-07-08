using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using HelperStuffs;

public class TextBinder : MonoBehaviour {
	int lastScore = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		int score = Helper.getGameManager().Score;

		if (lastScore <= score)
		{
			gameObject.GetComponent<Text>().text = lastScore.ToString();

			// Hopefully not buggy
			// A E S T H E T I C
			if ((float)score - lastScore> 200)
			{
				lastScore += 100;
			}
			if ((float)score - lastScore> 20)
			{
				lastScore += 10;
			}
			else
			{
				lastScore++;
			}
		}


	}
}
