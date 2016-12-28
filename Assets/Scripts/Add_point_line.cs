using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Add_point_line : MonoBehaviour {
	public GameObject []Row_Line=new GameObject[12];
	public GameObject []Column_Line=new GameObject[12];
	public GameObject []LeftRight_Line = new GameObject[9];
	public GameObject[] RightLeft_Line = new GameObject[9];
	public GameObject []Point=new GameObject[16];
	public GameObject[] transparent_point = new GameObject[16];
	public GameObject line;
	public GameObject long_line;
	public GameObject point;
	public GameObject transparent;

	private int direct;

	// Use this for initialization
	void Awake () {
		switch (this.gameObject.name) {
		case "TopSurface":
			direct = Box.TOP;
			break;
		case "FrontSurface":
			direct = Box.FRONT;
			break;
		case "LeftSurface":
			direct = Box.LEFT;
			break;
		case "RightSurface":
			direct = Box.RIGHT;
			break;
		case "BackSurface":
			direct = Box.BACK;
			break;
		case "DownSurface":
			direct = Box.DOWN;
			break;
		}
		if (direct != Box.DOWN) {
			for (int i = 0; i < 16; i++) {
				Point [i] = Instantiate (point, transform.position, transform.rotation);
				Point [i].transform.SetParent (this.gameObject.transform);
				//MeshFilter temp= Point [i].AddComponent<MeshFilter>();
				Point [i].GetComponent<MeshFilter> ().mesh.name = "Sphere";
				Point [i].transform.localPosition = new Vector3 (-0.5f + 1 / 3f * (i % 4), 0.5f - 1 / 3f * (i / 4), 0);
				Point [i].GetComponent<Click_On_Off> ().set_property (direct, i);

				transparent_point[i]=Instantiate (transparent, transform.position, transform.rotation);
				transparent_point[i].transform.SetParent (this.gameObject.transform);
				transparent_point[i].GetComponent<MeshFilter> ().mesh.name = "Sphere";
				transparent_point[i].transform.localPosition = new Vector3 (-0.5f + 1 / 3f * (i % 4), 0.5f - 1 / 3f * (i / 4), 0);
				transparent_point [i].GetComponent<transparent_click> ().set_property (direct, i);
			}

			for (int i = 0; i < 12; i++) {
				Row_Line [i] = Instantiate (line, transform.position, transform.rotation);
				Row_Line [i].transform.SetParent (this.gameObject.transform);
				//Point[0]=GameObject.CreatePrimitive (PrimitiveType.Sphere);
				//MeshFilter temp= Row_Line [i].AddComponent<MeshFilter>();
				//temp.mesh.name="Cylinder";
				Row_Line [i].GetComponent<MeshFilter> ().mesh.name = "Cylinder";
				Row_Line [i].transform.localPosition = new Vector3 (1 / 3f * (-1 + i % 3), 1 / 2f - 1 / 3f * (i / 3), 0);
				Row_Line [i].transform.Rotate (0, 0, 90);
				Row_Line [i].GetComponent<Line_Info> ().set_property ( 4 * (i / 3) + i % 3, 4 * (i / 3) + i % 3 + 1);
				Row_Line [i].GetComponent<MeshRenderer> ().enabled = false;
			}

			for (int i = 0; i < 12; i++) {
				Column_Line [i] = Instantiate (line, transform.position, transform.rotation);
				Column_Line [i].transform.SetParent (this.gameObject.transform);
				//Point[0]=GameObject.CreatePrimitive (PrimitiveType.Sphere);
				//MeshFilter temp= Column_Line [i].AddComponent<MeshFilter>();
				Column_Line [i].GetComponent<MeshFilter> ().mesh.name = "Cylinder";
				Column_Line [i].transform.localPosition = new Vector3 (-1 / 2f + 1 / 3f * (i % 4), 1 / 3f * (1 - i / 4), 0);
				Column_Line [i].transform.Rotate (0, 0, 0);
				Column_Line [i].GetComponent<Line_Info> ().set_property ( i, i + 4);
				Column_Line [i].GetComponent<MeshRenderer> ().enabled = false;
			}
			for (int i = 0; i < 9; i++) {
				LeftRight_Line [i] = Instantiate (long_line, transform.position, transform.rotation);
				LeftRight_Line [i].transform.SetParent (this.gameObject.transform);
				LeftRight_Line [i].GetComponent<MeshFilter> ().mesh.name = "Cylinder";
				LeftRight_Line [i].transform.localPosition = new Vector3 (-1 / 3f + 1 / 3f * (i % 3), 1 / 3f - 1 / 3f * (i / 3), 0);
				LeftRight_Line [i].transform.Rotate (0, 0, 45);
				LeftRight_Line [i].GetComponent<Line_Info> ().set_property ( 4 * (i / 3) + i % 3, 4 * (i / 3) + i % 3 + 5);
				LeftRight_Line [i].GetComponent<MeshRenderer> ().enabled = false;
			}
			for (int i = 0; i < 9; i++) {
				RightLeft_Line [i] = Instantiate (long_line, transform.position, transform.rotation);
				RightLeft_Line [i].transform.SetParent (this.gameObject.transform);
				RightLeft_Line [i].GetComponent<MeshFilter> ().mesh.name = "Cylinder";
				RightLeft_Line [i].transform.localPosition = new Vector3 (-1 / 3f + 1 / 3f * (i % 3), 1 / 3f - 1 / 3f * (i / 3), 0);
				RightLeft_Line [i].transform.Rotate (0, 0, -45);
				RightLeft_Line [i].GetComponent<Line_Info> ().set_property ( 1 + 4 * (i / 3) + i % 3, 4 * (i / 3) + i % 3 + 4);
				RightLeft_Line [i].GetComponent<MeshRenderer> ().enabled = false;
			}
		}
	}
		
	// Update is called once per frame
	void Update (){
	}

	public void disable_all(){
		for (int i = 0; i < 16; i++){
			Point [i].SetActive (false);
			transparent_point [i].SetActive (false);
		}
	}

	public void enable_all(){
		for (int i = 0; i < 16; i++) {
			Point [i].SetActive (true);
			transparent_point [i].SetActive (true);
		}
	}
}
