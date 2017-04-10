using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdBehaviour : MonoBehaviour
{
	public bool escape;
	// Use this for initialization
	void Start ()
	{
		escape = false;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (escape) {
			this.transform.Translate (Vector3.forward * 0.1f);
			this.transform.Translate (Vector3.up * 0.03f);
		}
	}
}
