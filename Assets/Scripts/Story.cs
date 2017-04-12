using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Story : MonoBehaviour {

	int picture;
	RawImage rawImage;
	GameObject[] objs;
	// Use this for initialization
	void Start () {
		picture = 1;
		rawImage = GameObject.Find ("Canvas/StoryCanvas/RawImage").GetComponent<RawImage> ();
		objs = new GameObject[9];
		objs [0] = GameObject.Find ("Canvas/LeftButton");
		objs [1] = GameObject.Find ("Canvas/RightButton");
		objs [2] = GameObject.Find ("Canvas/MiddleButton");
		objs [3] = GameObject.Find ("Canvas/ReturnButton");
		objs [4] = GameObject.Find ("Canvas/RawImage");
		objs [5] = GameObject.Find ("Canvas/ClearButton");
		objs [6] = GameObject.Find ("GlobalCanvas/MusicButton");
		objs [7] = GameObject.Find ("Box");
		objs[8]=GameObject.Find ("Canvas/GameOverCanvas");

		foreach (GameObject obj in objs) {
			obj.SetActive (false);
		}

	}

	public void NextClick(){
		picture++;
		if (picture == 5) {
			GameObject.Find ("Canvas/StoryCanvas").SetActive (false);
			foreach (GameObject obj in objs) {
				obj.SetActive (true);
			}
		} else {
			rawImage.texture = Resources.Load ("images/"+picture) as Texture;
		}
	}
	// Update is called once per frame
	void Update () {
		
	}
}
