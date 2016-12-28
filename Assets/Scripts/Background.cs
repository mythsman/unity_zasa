using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Background : MonoBehaviour {
	Skybox skyBox;
	// Use this for initialization
	void Start () {
		skyBox=GameObject.Find ("Main Camera").GetComponent<Skybox>();
		//Screen.SetResolution(1280, 800, true, 60);
		Screen.SetResolution (1600, 900, true);

	}
	
	// Update is called once per frame
	void Update () {
		skyBox.transform.Rotate (0.1f,0.1f,0.1f);

	}
}
