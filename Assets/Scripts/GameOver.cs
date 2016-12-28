using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void NextOnClick(){
		Global.level++;
		if (Global.level > 20) {
			Global.level = 1;
		}
		LevelButton.SetLevel (Global.level);
		SceneManager.LoadScene ("Zasa");
	}

	public void ReplayOnClick(){
		SceneManager.LoadScene ("Zasa");
	}
	public void ReturnOnClick(){
		SceneManager.LoadScene ("Welcome");
	}
}

