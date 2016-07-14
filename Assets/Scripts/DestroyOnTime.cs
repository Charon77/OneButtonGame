using UnityEngine;
using System.Collections;

public class DestroyOnTime : MonoBehaviour {

	public float lifetime; //bisa dihapus, untuk menghilangkan object
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		lifetime -= Time.deltaTime;

		if (lifetime < 0) {
			Destroy (gameObject);
		}
	
	}
}
