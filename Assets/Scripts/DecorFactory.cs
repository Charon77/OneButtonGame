using UnityEngine;
using System.Collections;
using HelperStuffs;
public class DecorFactory : MonoBehaviour {

	[SerializeField] GameObject Tree;

	GameObject Background;

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

	public void PutPlant (GameObject background)
	{
		ClearAll(background);
		GameObject tree = (GameObject) Instantiate (Tree);
		tree.transform.SetParent(background.transform,false);

		tree.transform.Translate (
			new Vector3(
				Random.Range(
					-background.GetComponent<SpriteRenderer>().bounds.extents.x,
					background.GetComponent<SpriteRenderer>().bounds.extents.x),0,0
			)
		);
	}
}
