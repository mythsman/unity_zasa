using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour {
	Skybox skyBox;
	// Use this for initialization
	void Start () {
		skyBox=GameObject.Find ("Main Camera").GetComponent<Skybox>();
		//Texture2D texture = Resources.Load ("icons/circle20") as Texture2D;
		//Cursor.SetCursor (texture,new Vector2(16,16),CursorMode.ForceSoftware);
	}
	
	// Update is called once per frame
	void Update () {
		skyBox.transform.Rotate (0.1f,0.1f,0.1f);

	}
}
