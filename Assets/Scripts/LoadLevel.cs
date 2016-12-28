using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LoadLevel : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameObject.Find ("Canvas/RawImage").GetComponent<RawImage> ().texture = Resources.Load ("targets/level"+Global.level)as Texture;

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
