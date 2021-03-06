﻿using UnityEngine;
using System.Collections;

public class EnemyFactory : MonoBehaviour {
	[SerializeField] GameObject WalkingGuard;
	[SerializeField] GameObject DoorGuard;
	[SerializeField] GameObject StandingGuard;
	[SerializeField] GameObject Costumer;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ClearAll(GameObject background)
	{
		for (int i=0; i<background.transform.childCount; i++)
		{
			Destroy(background.transform.GetChild(i).gameObject);
		}
	}

	public void PutWalkingGuard (GameObject background)
	{
		PutGuard(background, WalkingGuard);
	}

	public void PutStandingGuard (GameObject background)
	{
		PutGuard(background, StandingGuard);
	}

	public void PutDoorGuard (GameObject background)
	{
		PutGuard(background, DoorGuard);
	}
	public void PutDoorCostumer (GameObject background)
	{
		PutGuard(background, Costumer);
	}
	public void PutGuard (GameObject background, GameObject guard)
	{
		GameObject spawnedGuard = (GameObject) Instantiate (guard);
		spawnedGuard.transform.SetParent(background.transform,false);

		// Spawns at random position
		spawnedGuard.transform.Translate (
				new Vector3(
					Random.Range(
						-background.GetComponent<SpriteRenderer>().bounds.extents.x,
						background.GetComponent<SpriteRenderer>().bounds.extents.x),0,0
				)
			);
	}

	public void PutRandomGuard (GameObject background)
	{
		int randInt = Random.Range(0,4);

		switch (randInt) {
			case 0:
				PutWalkingGuard(background);
				break;
			case 1:
				PutStandingGuard(background);
				break;
			case 2:
				PutDoorGuard(background);
				break;
			case 3:
				PutDoorCostumer(background);
				break;
			default:
				break;
		}


	}
}
