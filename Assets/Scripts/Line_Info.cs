using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.InteropServices;

public class Line_Info : MonoBehaviour {
	int direct_from;
	int direct_to;
	public bool turn_on;
	public Texture t1;
	public Texture t2;
	// Use this for initialization
	void Start () {
		turn_on = false;
		GetComponent<MeshRenderer> ().material.mainTexture = t1;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void set_active(){
		turn_on = true;
	}

	public bool Is_on(){
		return turn_on;
	}

	public void set_property(int f,int t){
		//direct = d;
		direct_from = f;
		direct_to = t;
	}

	/*
	void OnTriggerStay(Collider other){
		if (other.gameObject.name=="Cylinder" && other.GetComponent<MeshRenderer> ().material.color == Color.red && this.gameObject.GetComponent<MeshRenderer> ().material.color != Color.red) {
			this.gameObject.GetComponent<MeshRenderer> ().material.color = Color.red;
			turn_on = true;
		}
	}
	*/

	public void set_color(){
		//GetComponent<MeshRenderer> ().material.mainTexture = t2;
		this.gameObject.GetComponent<MeshRenderer>().enabled=true;
		//this.gameObject.GetComponent<MeshRenderer>().material.color=Color.red;
		set_active ();
	}

	public bool equal(int f,int t){
		return direct_from==f&&direct_to==t||direct_from==t&&direct_to==f;
	}
		
}
