using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Box : MonoBehaviour
{
	
	public const int FRONT = 0;
	public const int LEFT = 1;
	public const int RIGHT = 2;
	public const int BACK = 3;
	public const int TOP = 4;
	public const int DOWN = 5;

	public ArrayList[,] Items = new ArrayList[6,6];

	public static int[] top_turn_left = { 12, 8, 4, 0, 13, 9, 5, 1, 14, 10, 6, 2, 15, 11, 7, 3 };
	public static int[] top_turn_right = { 3, 7, 11, 15, 2, 6, 10, 14, 1, 5, 9, 13, 0, 4, 8, 12 };

	public static int direction = FRONT;
	public static ArrayList surfaces = new ArrayList (4);

	private static bool rotating=false;
	public static bool IsRotating(){
		return rotating;
	}
	public static void ToggleRotate(){
		rotating = !rotating;
	}

	public static void TurnLeft ()
	{
		int dir,index;
		if (Point_List.sure_index>=0 && (Point_List.sure_index ==0 || !Main.Is_Line_On ((point)Point_List.point_list [Point_List.sure_index], (point)Point_List.point_list [Point_List.sure_index - 1]))) {
			dir = ((point)(Point_List.point_list [Point_List.sure_index])).direct;
			index = ((point)Point_List.point_list [Point_List.sure_index]).index;
			switch (dir) {
			case 0:
				dir = 2;
				break;
			case 2:
				dir = 3;
				break;
			case 3:
				dir = 1;
				break;
			case 1:
				dir = 0;
				break;
			case 4:
				index=top_turn_left[index];
				break;
			default:
				break;	
			}
			((point)Point_List.point_list [Point_List.sure_index]).set_color (0);
			Point_List.point_list.RemoveAt (Point_List.sure_index);
			Main.table [dir, index].set_color (0);
			Point_List.point_list.Add (Main.table [dir,index]);
		}
		else if(Point_List.sure_index>=0){
			dir = ((point)(Point_List.point_list [Point_List.sure_index])).direct;
			index = ((point)Point_List.point_list [Point_List.sure_index]).index;
			//Debug.Log (dir);
			//Debug.Log (index);
			switch (dir) {
			case 0:
				dir = 2;
				break;
			case 2:
				dir = 3;
				break;
			case 3:
				dir = 1;
				break;
			case 1:
				dir = 0;
				break;
			case 4:
				index = top_turn_left [index];
				break;
			default:
				break;	
			}
			Main.table [dir, index].set_color (0);
			Point_List.point_list.Add (Main.table [dir,index]);
			Point_List.sure_index += 1;
			((point)Point_List.point_list [Point_List.sure_index-1]).set_color (0);
		}


		switch (direction) {
		case FRONT:
			direction = RIGHT;
			break;
		case LEFT:
			direction = FRONT;
			break;
		case RIGHT:
			direction = BACK;
			break;
		case BACK:
			direction = LEFT;
			break;
		}

	}

	public static void TurnRight ()
	{
		int dir, index;
		if (Point_List.sure_index>=0 && (Point_List.sure_index ==0 || !Main.Is_Line_On ((point)Point_List.point_list [Point_List.sure_index], (point)Point_List.point_list [Point_List.sure_index - 1]))) {
			dir = ((point)(Point_List.point_list [Point_List.sure_index])).direct;
			index = ((point)Point_List.point_list [Point_List.sure_index]).index;
			switch (dir) {
			case 0:
				dir = 1;
				break;
			case 2:
				dir = 0;
				break;
			case 3:
				dir = 2;
				break;
			case 1:
				dir = 3;
				break;
			case 4:
				index=top_turn_right[index];
				break;
			default:
				break;	
			}
			((point)Point_List.point_list [Point_List.sure_index]).set_color (0);
			Point_List.point_list.RemoveAt (Point_List.sure_index);
			Main.table [dir, index].set_color (0);
			Point_List.point_list.Add (Main.table [dir,index]);
		}
		else if(Point_List.sure_index>=0){
			dir = ((point)(Point_List.point_list [Point_List.sure_index])).direct;
			index = ((point)Point_List.point_list [Point_List.sure_index]).index;
			switch (dir) {
			case 0:
				dir = 1;
				break;
			case 2:
				dir = 0;
				break;
			case 3:
				dir = 2;
				break;
			case 1:
				dir = 3;
				break;
			case 4:
				index = top_turn_right [index];
				break;
			default:
				break;	
			}
			Main.table [dir, index].set_color (0);
			Point_List.point_list.Add (Main.table [dir,index]);
			Point_List.sure_index += 1;
			((point)Point_List.point_list [Point_List.sure_index-1]).set_color (0);
		}

		switch (direction) {
		case FRONT:
			direction = LEFT;
			break;
		case LEFT:
			direction = BACK;
			break;
		case RIGHT:
			direction = FRONT;
			break;
		case BACK:
			direction = RIGHT;
			break;
		}
	}

	public static ArrayList GetSurfaces ()
	{
		ArrayList output = new ArrayList (4);

		output.Add (null);
		output.Add (null);
		output.Add (null);
		output.Add (null);
		switch (direction) {
		case FRONT:
			output [FRONT] = surfaces [FRONT];
			output [LEFT] = surfaces [LEFT];
			output [RIGHT] = surfaces [RIGHT];
			output [BACK] = surfaces [BACK];
			break;
		case LEFT:
			output [FRONT] = surfaces [LEFT];
			output [LEFT] = surfaces [BACK];
			output [RIGHT] = surfaces [FRONT];
			output [BACK] = surfaces [RIGHT];
			break;
		case RIGHT:
			output [FRONT] = surfaces [RIGHT];
			output [LEFT] = surfaces [FRONT];
			output [RIGHT] = surfaces [BACK];
			output [BACK] = surfaces [LEFT];
			break;
		case BACK:
			output [FRONT] = surfaces [BACK];
			output [LEFT] = surfaces [RIGHT];
			output [RIGHT] = surfaces [LEFT];
			output [BACK] = surfaces [FRONT];
			break;
		}
		return output;
	}



	// Use this for initialization
	void Start ()
	{
		direction = FRONT;
		surfaces.Add (null);
		surfaces.Add (null);
		surfaces.Add (null);
		surfaces.Add (null);
		surfaces [FRONT] = GameObject.Find ("Box/FrontSurface");
		surfaces [LEFT] = GameObject.Find ("Box/LeftSurface");
		surfaces [RIGHT] = GameObject.Find ("Box/RightSurface");
		surfaces [BACK] = GameObject.Find ("Box/BackSurface");
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}
}
	