using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {

	GameObject[] objs;
	// Use this for initialization
	void Start () {
		objs = new GameObject[8];
		objs [0] = GameObject.Find ("Canvas/LeftButton");
		objs [1] = GameObject.Find ("Canvas/RightButton");
		objs [2] = GameObject.Find ("Canvas/MiddleButton");
		objs [3] = GameObject.Find ("Canvas/ReturnButton");
		objs [4] = GameObject.Find ("Canvas/RawImage");
		objs [5] = GameObject.Find ("Canvas/ClearButton");
		objs [6] = GameObject.Find ("GlobalCanvas/MusicButton");
		objs [7] = GameObject.Find ("Box/Cube");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void hideButtons(){
		foreach (GameObject obj in objs) {
			obj.SetActive (false);
		}
	}

	void Restore(){
		objs [6].SetActive (true);
	}

	public void NextOnClick(){
		Restore ();
		Global.level++;
		if (Global.level > 20) {
			Global.level = 1;
		}
		LevelButton.SetLevel (Global.level);
		SceneManager.LoadScene ("Zasa");
	}

	public void ReplayOnClick(){
		Restore ();
		SceneManager.LoadScene ("Zasa");
	}
	public void ReturnOnClick(){
		Restore ();
		SceneManager.LoadScene ("Welcome");
	}
}