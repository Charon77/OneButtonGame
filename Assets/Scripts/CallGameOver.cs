using UnityEngine;
using System.Collections;

public class CallGameOver : MonoBehaviour {

	[SerializeField] GameObject GameOverObject;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(!GetComponent<AudioSource>().isPlaying)
		{
			Instantiate(GameOverObject);
		}
	}
}
