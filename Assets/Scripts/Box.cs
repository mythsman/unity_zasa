using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Box : MonoBehaviour
{
	
	public const int FRONT = 0;
	public const int LEFT = 1;
	public const int RIGHT = 2;
	public const int BACK = 3;


	private static int direction = FRONT;
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
	