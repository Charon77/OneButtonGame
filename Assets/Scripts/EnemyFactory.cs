using UnityEngine;
using System.Collections;

public class EnemyFactory : MonoBehaviour {
	[SerializeField] GameObject WalkingGuard;

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
}
