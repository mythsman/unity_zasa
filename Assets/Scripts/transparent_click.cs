using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transparent_click : MonoBehaviour {
	public int direct;
	public int index;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown() {
		Point_List.point_list.Add (Main.table[direct,index]);
	}
		
	public void set_property(int d,int i){
		direct = d;
		index = i;
	}

}
