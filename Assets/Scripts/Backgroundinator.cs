﻿using UnityEngine;
using System.Collections;

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
				summonedBackground.GetComponent<Moveable>().blinkToPos(spawnPointForNewBackground);
			}
		}
	}
}
