﻿using UnityEngine;
using System.Collections;
using HelperStuffs;
using System.Linq;


public class DecorFactory : MonoBehaviour {

	[SerializeField] GameObject Tree;
	[SerializeField] GameObject Baa;
	[SerializeField] GameObject Bulletinboard;
	//[SerializeField] GameObject Door;
	[SerializeField] GameObject Exit;
	[SerializeField] GameObject Toilet;
	[SerializeField] GameObject Trash;

	// Use this for initialization
	void Start () {
		if (Tree == null || Baa == null || Bulletinboard == null || Exit == null || Toilet == null || Trash == null)
		{
			Debug.LogWarning("Prefabs seems empty, or DecorFactory reinstantiated more than once. UNRESOLVED problem.");
			Destroy(gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// Warning: Clears not just decors
	public void ClearAll(GameObject background)
	{
		for (int i=0; i<background.transform.childCount; i++)
		{
			Destroy(background.transform.GetChild(i).gameObject);
		}
	}

	public void PutDecor (GameObject background, GameObject decor)
	{
		GameObject spawnedDecor = (GameObject) Instantiate (decor);
		spawnedDecor.transform.SetParent(background.transform,false);

		spawnedDecor.transform.Translate (
			new Vector3(
				Random.Range(
					-background.GetComponent<SpriteRenderer>().bounds.extents.x,
					background.GetComponent<SpriteRenderer>().bounds.extents.x),0,0
			)
		);
	}

	public void PutPlant (GameObject background)
	{
		PutDecor(background, Tree);
	}

	public void PutBaa (GameObject background)
	{
		PutDecor(background, Baa);
	}

	public void PutBulletinboard (GameObject background)
	{
		PutDecor(background, Bulletinboard);
	}

	//public void PutDoor (GameObject background)
	//{
	//	PutDecor(background, Door);
	//}

	public void PutExit (GameObject background)
	{
		PutDecor(background, Exit);
	}

	public void PutToilet (GameObject background)
	{
		PutDecor(background, Toilet);
	}

	public void PutTrash (GameObject background)
	{
		PutDecor(background, Trash);
	}

	public void PutRandomDecors (GameObject background, int count)
	{
		foreach (var i in Enumerable.Range(0, count) ) {
			PutRandomDecor(background);
		}
	}

	public void PutRandomDecor (GameObject background)
	{
		int randInt = Random.Range(0,7);

		switch (randInt) {
		case 0:
			PutBaa(background);
			break;
		case 1:
			PutBulletinboard(background);
			break;
		case 2:
			PutTrash (background);
			//PutDoor(background);
			break;
		case 3:
			PutExit(background);
			break;
		case 4:
			PutPlant (background);
			break;
		case 5:
			PutToilet (background);
			break;
		case 6:
			PutTrash (background);
			break;
		default:
			break;
		}


	}
}
