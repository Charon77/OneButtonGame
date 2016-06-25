using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

public class Backgroundinator : MonoBehaviour{
	[SerializeField] Sprite backgroundSprite;
	[SerializeField] GameObject backgroundTemplate;
	GameObject[] summonedBackgroundList = new GameObject[4];
	float xOffset = 0;
	Vector3 spawnPointForNewBackground = Vector3.zero;

	// Use this for initialization
	void Start () {

		for (int i=0; i<summonedBackgroundList.Length; i++) {

			// Create background
			summonedBackgroundList[i] = Instantiate(backgroundTemplate);
			var summonedBackground = summonedBackgroundList[i];
			summonedBackground.transform.localPosition = Vector3.zero;

			var backgroundSpriteRenderer = summonedBackground.GetComponent<SpriteRenderer>();

			// Offset to the right
			summonedBackground.transform.Translate(spawnPointForNewBackground);

			//Change sprite
			backgroundSpriteRenderer.sprite = backgroundSprite;

			// Add offset
			xOffset += backgroundSpriteRenderer.bounds.size.x;
			spawnPointForNewBackground = new Vector3(xOffset,0,0);
		}
	}
	
	// Update is called once per frame
	void Update () {



		foreach (var summonedBackground in summonedBackgroundList) {
			if (summonedBackground.transform.localPosition.x < -backgroundSprite.bounds.size.x )
			{
				// Find rightmost background
				Array.Sort(summonedBackgroundList, new CompareByXPosition());
				var Rightmost = summonedBackgroundList[0];
				summonedBackground.GetComponent<Moveable>().blinkToPos(
					new Vector3 (
						Rightmost.GetComponent<SpriteRenderer>().bounds.size.x + Rightmost.transform.localPosition.x
						,0,0)
				);
			}
		}
	}
}


class CompareByXPosition : IComparer<GameObject>
{
	#region IComparer implementation
	public int Compare (GameObject x, GameObject y)
	{
		
		return Math.Sign(y.transform.localPosition.x - x.transform.localPosition.x);
	}
	#endregion
						
}
