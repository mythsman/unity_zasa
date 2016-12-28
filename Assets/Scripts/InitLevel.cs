using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InitLevel : MonoBehaviour {

	// Use this for initialization
	void Start () {
		int totalStars = 0;
		for (int i = 1; i <= 12; i++) {
			int stars=PlayerPrefs.GetInt ("level" + i);
			totalStars += stars;
			GameObject.Find ("Canvas/Scroll View/Viewport/Content/Level" + i + "/RawImage").GetComponent<RawImage> ().texture=Resources.Load("stars/levelbutton"+stars) as Texture;
				
		}
		GameObject.Find ("Canvas/Panel/Text").GetComponent<Text> ().text=totalStars+"/36";

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
