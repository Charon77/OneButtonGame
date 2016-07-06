using UnityEngine;
using System.Collections;

public class DesColliderCheck : MonoBehaviour {

	[SerializeField] string nama_sprite;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log ( gameObject.GetComponent<SpriteRenderer> ().sprite.name);
		if (gameObject.GetComponent<SpriteRenderer> ().sprite.name == nama_sprite) {
			gameObject.GetComponent<Collider2D> ().enabled = false;

		} else {
			gameObject.GetComponent<Collider2D> ().enabled = true;

			

		}
	
	}
}
