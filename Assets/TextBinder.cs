using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using HelperStuffs;

public class TextBinder : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.GetComponent<Text>().text = Helper.getGameManager().Score.ToString();
	}
}
