using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temp : MonoBehaviour {

	private bool showWindow=false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void OnClick(){
		showWindow = true;
	}
	void func(int a){

		GUI.Button (new Rect (60, 350, 120, 100), "Restart");
		GUI.Button (new Rect (240, 350, 120, 100), "Return");
		GUI.Button (new Rect (420, 350, 120, 100), "Next");

	}
	void OnGUI(){

		if (showWindow) {
			GUIStyle style=new GUIStyle();

			GUI.Window (0, new Rect (500, 200, 600, 500), func, "Game Over",style);

		}
	}
}
