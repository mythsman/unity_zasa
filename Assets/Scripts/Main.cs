using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{

	public static point[,] table = new point[5, 16];

	// Use this for initialization
	void Start ()
	{
		
		GameObject temp1 = GameObject.Find ("Box/FrontSurface");
		for (int i = 0; i < 16; i++) {
			point a = new point (i % 4, i / 4, 0);
			a.store_local (temp1.GetComponent<Add_point_line> ().Point [i].GetComponent<Click_On_Off> ().direct, temp1.GetComponent<Add_point_line> ().Point [i].GetComponent<Click_On_Off> ().index);
			table [0, i] = a;
		}
		GameObject temp2 = GameObject.Find ("Box/LeftSurface");
		for (int i = 0; i < 16; i++) {
			point a = new point (0, i / 4, 3 - i % 4);
			a.store_local (temp2.GetComponent<Add_point_line> ().Point [i].GetComponent<Click_On_Off> ().direct, temp2.GetComponent<Add_point_line> ().Point [i].GetComponent<Click_On_Off> ().index);
			table [1, i] = a;
		}
		GameObject temp3 = GameObject.Find ("Box/RightSurface");
		for (int i = 0; i < 16; i++) {
			point a = new point (3, i / 4, i % 4);
			a.store_local (temp3.GetComponent<Add_point_line> ().Point [i].GetComponent<Click_On_Off> ().direct, temp3.GetComponent<Add_point_line> ().Point [i].GetComponent<Click_On_Off> ().index);
			table [2, i] = a;
		}
		GameObject temp4 = GameObject.Find ("Box/BackSurface");
		for (int i = 0; i < 16; i++) {
			point a = new point (3 - i % 4, i / 4, 3);
			a.store_local (temp4.GetComponent<Add_point_line> ().Point [i].GetComponent<Click_On_Off> ().direct, temp4.GetComponent<Add_point_line> ().Point [i].GetComponent<Click_On_Off> ().index);
			table [3, i] = a;
		}
		GameObject temp5 = GameObject.Find ("Box/TopSurface");
		for (int i = 0; i < 16; i++) {
			point a = new point (i % 4, 0, 3 - i / 4);
			a.store_local (temp5.GetComponent<Add_point_line> ().Point [i].GetComponent<Click_On_Off> ().direct, temp5.GetComponent<Add_point_line> ().Point [i].GetComponent<Click_On_Off> ().index);
			table [4, i] = a;
		}


		for (int i = 0; i < 5; i++)
			for (int j = 0; j < 16; j++)
				for (int k = 0; k < 5; k++)
					for (int l = 0; l < 16; l++)
						if ((i != k || j != l) && table [i, j].x == table [k, l].x && table [i, j].y == table [k, l].y && table [i, j].z == table [k, l].z) {
							table [i, j].store_local (k, l);
						}
	}


	public static bool Is_Line_On (point a, point b)
	{
		for (int i = 0; i < a.local_pos.Count; i++) {
			for (int j = 0; j < b.local_pos.Count; j++) {
				if ((int)(((ArrayList)(a.local_pos [i])) [0]) == (int)(((ArrayList)(b.local_pos [j])) [0])) {
					GameObject temp = find_direct ((int)(((ArrayList)(a.local_pos [i])) [0]));
					for (int k = 0; k < 12; k++) {
						if (((GameObject)temp.GetComponent<Add_point_line> ().Row_Line [k]).GetComponent<Line_Info> ().equal ((int)(((ArrayList)a.local_pos [i]) [1]), (int)(((ArrayList)b.local_pos [j]) [1]))
						    && ((GameObject)temp.GetComponent<Add_point_line> ().Row_Line [k]).GetComponent<Line_Info> ().Is_on ())
							return true;
						if (((GameObject)temp.GetComponent<Add_point_line> ().Column_Line [k]).GetComponent<Line_Info> ().equal ((int)(((ArrayList)a.local_pos [i]) [1]), (int)(((ArrayList)b.local_pos [j]) [1]))
						    && ((GameObject)temp.GetComponent<Add_point_line> ().Column_Line [k]).GetComponent<Line_Info> ().Is_on ())
							return true;
					}
					for (int k = 0; k < 9; k++) {
						if (((GameObject)temp.GetComponent<Add_point_line> ().LeftRight_Line [k]).GetComponent<Line_Info> ().equal ((int)(((ArrayList)a.local_pos [i]) [1]), (int)(((ArrayList)b.local_pos [j]) [1]))
						    && ((GameObject)temp.GetComponent<Add_point_line> ().LeftRight_Line [k]).GetComponent<Line_Info> ().Is_on ())
							return true;
						if (((GameObject)temp.GetComponent<Add_point_line> ().RightLeft_Line [k]).GetComponent<Line_Info> ().equal ((int)(((ArrayList)a.local_pos [i]) [1]), (int)(((ArrayList)b.local_pos [j]) [1]))
						    && ((GameObject)temp.GetComponent<Add_point_line> ().RightLeft_Line [k]).GetComponent<Line_Info> ().Is_on ())
							return true;
					}
				}
			}
		}
		return false;
	}

	public static GameObject find_direct (int d)
	{
		switch (d) {
		case 0:
			return GameObject.Find ("Box/FrontSurface");
		case 1:
			return GameObject.Find ("Box/LeftSurface");
		case 2:
			return GameObject.Find ("Box/RightSurface");
		case 3:
			return GameObject.Find ("Box/BackSurface");
		case 4:
			return GameObject.Find ("Box/TopSurface");
		default:
			return null;
		}
	}

	bool find_line_and_color (point a, point b)
	{
		bool flag = false;
		for (int i = 0; i < a.local_pos.Count; i++) {
			for (int j = 0; j < b.local_pos.Count; j++) {
				if ((int)(((ArrayList)(a.local_pos [i])) [0]) == (int)(((ArrayList)(b.local_pos [j])) [0])) {
					GameObject temp = find_direct ((int)(((ArrayList)(a.local_pos [i])) [0]));
					for (int k = 0; k < 12; k++) {
						if (((GameObject)temp.GetComponent<Add_point_line> ().Row_Line [k]).GetComponent<Line_Info> ().equal ((int)(((ArrayList)a.local_pos [i]) [1]), (int)(((ArrayList)b.local_pos [j]) [1]))) {
							((GameObject)temp.GetComponent<Add_point_line> ().Row_Line [k]).GetComponent<Line_Info> ().set_color ();
							flag = true;
						}
						if (((GameObject)temp.GetComponent<Add_point_line> ().Column_Line [k]).GetComponent<Line_Info> ().equal ((int)(((ArrayList)a.local_pos [i]) [1]), (int)(((ArrayList)b.local_pos [j]) [1]))) {
							((GameObject)temp.GetComponent<Add_point_line> ().Column_Line [k]).GetComponent<Line_Info> ().set_color ();
							flag = true;
						}
					}
					for (int k = 0; k < 9; k++) {
						if (((GameObject)temp.GetComponent<Add_point_line> ().LeftRight_Line [k]).GetComponent<Line_Info> ().equal ((int)(((ArrayList)a.local_pos [i]) [1]), (int)(((ArrayList)b.local_pos [j]) [1]))) {
							((GameObject)temp.GetComponent<Add_point_line> ().LeftRight_Line [k]).GetComponent<Line_Info> ().set_color ();
							flag = true;
						}
						if (((GameObject)temp.GetComponent<Add_point_line> ().RightLeft_Line [k]).GetComponent<Line_Info> ().equal ((int)(((ArrayList)a.local_pos [i]) [1]), (int)(((ArrayList)b.local_pos [j]) [1]))) {
							((GameObject)temp.GetComponent<Add_point_line> ().RightLeft_Line [k]).GetComponent<Line_Info> ().set_color ();
							flag = true;
						}
					}
				}
			}
		}
		return flag;
	}

	// Update is called once per frame

	void Update ()
	{
		try {
			if (Point_List.point_list.Count > Point_List.sure_index + 1) {
				if (Point_List.sure_index < 0) {
					Point_List.sure_index = 0;
					((point)(Point_List.point_list [0])).set_color (1);
				} else {
					int flag = 0;
					for (int i = 0; i < Point_List.sure_index + 1; i++) {
						if (((point)(Point_List.point_list [i])).x == ((point)(Point_List.point_list [Point_List.sure_index + 1])).x &&
						   ((point)(Point_List.point_list [i])).y == ((point)(Point_List.point_list [Point_List.sure_index + 1])).y &&
						   ((point)(Point_List.point_list [i])).z == ((point)(Point_List.point_list [Point_List.sure_index + 1])).z &&
						   Is_Line_On ((point)(Point_List.point_list [Point_List.sure_index]), (point)(Point_List.point_list [Point_List.sure_index + 1]))) {
							Point_List.point_list.RemoveAt (Point_List.sure_index + 1);
							flag = 1;
							break;
						}
					}
					if (flag == 0) {
						if (find_line_and_color (((point)Point_List.point_list [Point_List.sure_index]), ((point)Point_List.point_list [Point_List.sure_index + 1]))) {
							Point_List.sure_index += 1;
							((point)Point_List.point_list [Point_List.sure_index]).set_color (1);
							((point)Point_List.point_list [Point_List.sure_index - 1]).set_color (0);
						} else {
							Point_List.point_list.RemoveAt (Point_List.sure_index + 1);
						}
					}
				}
			}
		} catch {
		}
	}
}
