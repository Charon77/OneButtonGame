using UnityEngine;
using System.Collections;

public class AnimateSelf : MonoBehaviour {

	[SerializeField]
	int frameSkip = 24;

	int lastTriggerFrame = 0;

	// Use this for initialization
	void Start () {
		GetComponent<AnimStepper>().Step();
	}
	
	// Update is called once per frame
	void Update () {
		var frameCount = Time.frameCount;
		if (frameCount -  lastTriggerFrame > frameSkip)
		{
			GetComponent<AnimStepper>().Step();
			lastTriggerFrame = frameCount;
		}

	}
}
