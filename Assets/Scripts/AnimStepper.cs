using UnityEngine;
using System.Collections;

public class AnimStepper : MonoBehaviour {
	[SerializeField]
	Sprite[] sprites;
	[SerializeField]
	bool backAndForth = false;
	[SerializeField]
	bool randomOrder = false;

	bool forward = true;
	int current_sprite = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Step() {

		if (randomOrder) {
			current_sprite = Random.Range (0, sprites.Length);
		}
		else if (!backAndForth)
		{
			current_sprite = sprites.Length > current_sprite+1 ? current_sprite+1 : 0;
		}
		else
		{
			if (forward)
			{
				if (sprites.Length > current_sprite+1)
				{
					current_sprite = current_sprite + 1;
				}
				else
				{
					// Flip direction
					forward = false;
					current_sprite = current_sprite - 1;
				}
			}
			else
			{
				if (current_sprite > 0)
				{
					current_sprite = current_sprite - 1;
				}
				else
				{
					// Flip direction
					forward = true;
					current_sprite = current_sprite + 1;
				}
			}
		}

		GetComponent<SpriteRenderer>().sprite = sprites[current_sprite];
	}
}
