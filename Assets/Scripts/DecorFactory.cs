using UnityEngine;
using System.Collections;
using HelperStuffs;
public class DecorFactory : MonoBehaviour {

	[SerializeField] GameObject Tree;

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

	public void PutDecor (GameObject background, GameObject decor)
	{
		ClearAll(background);
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
}
