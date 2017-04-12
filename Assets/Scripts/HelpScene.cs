using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class HelpScene : MonoBehaviour {
	int picture;
	int time;
	RawImage rawImage;
	RawImage buttonImage;
	Color trans = new Color (1f, 1f, 1f, 0);
	Color solid=new Color(1f,1f,1f,1f);

	// Use this for initialization
	void Start () {
		picture = 1;
		time = 0;
		rawImage = GameObject.Find ("Canvas/RawImage").GetComponent<RawImage> ();
		rawImage.texture = Resources.Load ("images/help"+picture) as Texture;
		buttonImage = GameObject.Find ("Canvas/Button/RawImage").GetComponent<RawImage> ();
	}
	public void Click(){
		picture++;
		if (picture == 7) {
			SceneManager.LoadScene("Welcome");
		} else {
			rawImage.texture = Resources.Load ("images/help"+picture) as Texture;
		}
	}
	// Update is called once per frame
	void Update () {
		time++;
		if (time == 40) {
			buttonImage.color = trans;

		} else if (time == 80) {
			time = 0;
			buttonImage.color = solid;
		}
	}
}
