using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class point {

	public int x, y, z;
	public int direct,index;
	public ArrayList local_pos = new ArrayList ();

	Color[] color = { Color.white, new Color(0.8f,0,0) };

	public point(int _x,int _y,int _z){
		x = _x;
		y = _y;
		z = _z;
	}

	public void set_color(int num){
		try{
			for (int i = 0; i < local_pos.Count; i++) {
				switch ((int)(((ArrayList)local_pos[i])[0])) {
				case 0:
					GameObject.Find ("Box/FrontSurface").GetComponent<Add_point_line> ().Point [(int)((ArrayList)local_pos [i])[1]].GetComponent<MeshRenderer> ().material.color = color[num];
					break;
				case 1:
					GameObject.Find ("Box/LeftSurface").GetComponent<Add_point_line> ().Point [(int)((ArrayList)local_pos [i])[1]].GetComponent<MeshRenderer> ().material.color = color[num];
					break;
				case 2:
					GameObject.Find ("Box/RightSurface").GetComponent<Add_point_line> ().Point [(int)((ArrayList)local_pos [i])[1]].GetComponent<MeshRenderer> ().material.color = color[num];
					break;
				case 3:
					GameObject.Find ("Box/BackSurface").GetComponent<Add_point_line> ().Point [(int)((ArrayList)local_pos [i] )[1]].GetComponent<MeshRenderer> ().material.color = color[num];
					break;
				case 4:
					GameObject.Find ("Box/TopSurface").GetComponent<Add_point_line> ().Point [(int)((ArrayList)local_pos [i] )[1]].GetComponent<MeshRenderer> ().material.color = color[num];
					break;
				}
			}
		}catch{
			 
		}
	}

	public void store_local(int d,int i){
		direct = d;
		index = i;
		ArrayList temp = new ArrayList ();
		temp.Add (direct);
		temp.Add (index);
		local_pos.Add (temp);
		direct = (int)((ArrayList)local_pos [0])[0];
		index = (int)((ArrayList)local_pos [0])[1];
	}

	/*
	public static bool operator==(point a,point b){
		return a.x == b.x && a.y == b.y && a.z == b.z;
	}

	public static bool operator!=(point a,point b){
		return a.x != b.x || a.y != b.y || a.z != b.z;
	}
	*/	
}
