using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class birdBehaviour : MonoBehaviour
{
	public bool escape;
	Animation animation;
	int time;
	// Use this for initialization
	void Start ()
	{
		animation = GetComponent<Animation> ();
		escape = false;
		time = 0;
	}
	
	// Update is called once per frame
	void Update ()
	{
		//animation.Play ("fly");
		if (escape) {
			this.transform.Translate (Vector3.forward * 0.1f);
			this.transform.Translate (Vector3.up * 0.03f);
			time++;
			if (time > 600) {
				time = 0;
				escape = false;
				GameObject.Find ("Canvas/GameOverCanvas").SetActive(true);
			}
		}
	}
}
