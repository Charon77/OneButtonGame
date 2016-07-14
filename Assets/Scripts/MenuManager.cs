using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour {

	// buat ngurusin nanti hal2 yang ada di main menu, 
	// bsa musik dan lainya
	// Use this for initialization
	[SerializeField] GameObject BGM;
	GameObject BGM_Manager;
	void Start () {
		Camera.main.aspect = 16f/9f;
		if (!GameObject.FindGameObjectWithTag("BGM")) {
			BGM_Manager = Instantiate (BGM);
			//test.name = BGM.name;
			DontDestroyOnLoad(BGM_Manager);
		}
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			ExitLevelButton ();
		}

	}



	public void PlayLevelButton()
	{
		SceneManager.LoadScene("main");
	}

	public void ExitLevelButton()
	{
		Application.Quit();
	}
	public void MainMenu()
	{
		SceneManager.LoadScene ("MainMenu");
	}


}


