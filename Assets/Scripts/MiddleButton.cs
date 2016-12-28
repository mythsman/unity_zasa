using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MiddleButton : MonoBehaviour
{
	public static int RotateCount = 0;
	private bool topView;
	private bool onRotate;
	private int process;
	private const int maxProcess = 20;
	private Transform cameraTransform;
	private Camera cameraCamera;
	private ArrayList surfaces;
	private bool success;
	private GameObject obj;

	// Use this for initialization
	void Start ()
	{
		obj = GameObject.Find ("Canvas/GameOverCanvas");
		obj.SetActive (false);
		success = false;
		RotateCount = 0;
		topView = false;
		onRotate = false;
		process = 0;
		cameraTransform = GameObject.Find ("Main Camera").GetComponent<Transform> ();
		cameraCamera = GameObject.Find ("Main Camera").GetComponent<Camera> ();

	}

	// Update is called once per frame
	void Update ()
	{
		if (success)
			return;
		if (topView&&IsSuccess ()) {
			//GameObject.Find ("Box").SetActive(false);
			obj.SetActive (true);
			int starNum = 1;
			if (RotateCount == Global.minStep)
				starNum = 3;
			else if (RotateCount + 2 >= Global.minStep) {
				starNum = 2;
			}
			GameObject.Find("Canvas/GameOverCanvas/Stars").GetComponent<RawImage>().texture=Resources.Load("stars/success"+starNum)as Texture;
			if (PlayerPrefs.GetInt ("level" + Global.level) < starNum) {
				PlayerPrefs.SetInt ("level" + Global.level,starNum);
			}
			success = true;
		}
		if (onRotate) {
			if (topView) {
				cameraTransform.RotateAround (new Vector3 (0, -1.5f, 0), new Vector3 (1, 0, 1), -54.74f / maxProcess);
				cameraTransform.Rotate (0, 0, 45f / maxProcess);
				cameraCamera.orthographicSize = 5-2.0f*process/maxProcess;


				((GameObject)surfaces[Box.FRONT]).GetComponent<Transform>().RotateAround (new Vector3 (0, 0, -1.5f), new Vector3 (1, 0, 0), -90f / maxProcess);
				((GameObject)surfaces[Box.BACK]).GetComponent<Transform>().RotateAround (new Vector3 (0, 0, 1.5f), new Vector3 (1, 0, 0), 90f / maxProcess);
				((GameObject)surfaces[Box.LEFT]).GetComponent<Transform>().RotateAround (new Vector3 (-1.5f, 0, 0), new Vector3 (0, 0, 1), 90f / maxProcess);
				((GameObject)surfaces[Box.RIGHT]).GetComponent<Transform>().RotateAround (new Vector3 (1.5f, 0, 0), new Vector3 (0, 0, 1), -90f / maxProcess);
				process++;
				if (process == maxProcess) {
					GameObject.Find ("TopSurface").GetComponent<Add_point_line> ().enable_all ();
					GameObject.Find ("FrontSurface").GetComponent<Add_point_line> ().enable_all ();
					GameObject.Find ("LeftSurface").GetComponent<Add_point_line> ().enable_all ();
					GameObject.Find ("RightSurface").GetComponent<Add_point_line> ().enable_all ();
					GameObject.Find ("BackSurface").GetComponent<Add_point_line> ().enable_all ();
					topView = false;
					onRotate = false;
					process = 0;
					Box.ToggleRotate ();
					cameraCamera.orthographicSize = 3;

				}
			} else {
				cameraTransform.RotateAround (new Vector3 (0, -1.5f, 0), new Vector3 (1, 0, 1), 54.74f / maxProcess);
				cameraTransform.Rotate (0, 0, -45f / maxProcess);
				cameraCamera.orthographicSize = 3+2.0f*process/maxProcess;

				((GameObject)surfaces[Box.FRONT]).GetComponent<Transform>().RotateAround (new Vector3 (0, 0, -1.5f), new Vector3 (1, 0, 0), 90f / maxProcess);
				((GameObject)surfaces[Box.BACK]).GetComponent<Transform>().RotateAround (new Vector3 (0, 0, 1.5f), new Vector3 (1, 0, 0), -90f / maxProcess);
				((GameObject)surfaces[Box.LEFT]).GetComponent<Transform>().RotateAround (new Vector3 (-1.5f, 0, 0), new Vector3 (0, 0, 1), -90f / maxProcess);
				((GameObject)surfaces[Box.RIGHT]).GetComponent<Transform>().RotateAround (new Vector3 (1.5f, 0, 0), new Vector3 (0, 0, 1), 90f / maxProcess);

				process++;
				if (process == maxProcess) {
					cameraCamera.orthographicSize = 5;
					topView = true;
					onRotate = false;
					process = 0;
					Box.ToggleRotate ();
				}
			}
		}
	}

	public static bool IsSuccess(){
		ArrayList surfaces = Box.GetSurfaces ();


		for (int k = 0; k < 4; k++) {
			Add_point_line a=((GameObject)surfaces [k]).GetComponent<Add_point_line> ();
			for (int i = 0; i < 12; i++) {
				if (a.Row_Line [i].GetComponent<Line_Info> ().Is_on () != Global.map [k, Global.ROW, i])
					return false;
			}
			for (int i = 0; i < 12; i++) {
				if (a.Column_Line [i].GetComponent<Line_Info> ().Is_on () != Global.map [k, Global.COLUMN, i])
					return false;
			}
			for (int i = 0; i < 9; i++) {
				if (a.LeftRight_Line[i].GetComponent<Line_Info> ().Is_on () != Global.map [k, Global.LEFTRIGHT, i])
					return false;
			}
			for (int i = 0; i < 9; i++) {
				if (a.RightLeft_Line [i].GetComponent<Line_Info> ().Is_on () != Global.map [k, Global.RIGHTLEFT, i])
					return false;
			}
		}

		Add_point_line b=((GameObject)GameObject.Find("Box/TopSurface")).GetComponent<Add_point_line> ();
		switch (Box.direction) {
		case Box.FRONT:
			for (int i = 0; i < 12; i++) {
				if (b.Row_Line [i].GetComponent<Line_Info> ().Is_on () != Global.map [Box.TOP, Global.ROW, i])
					return false;
			}
			for (int i = 0; i < 12; i++) {
				if (b.Column_Line [i].GetComponent<Line_Info> ().Is_on () != Global.map [Box.TOP, Global.COLUMN, i])
					return false;
			}
			for (int i = 0; i < 9; i++) {
				if (b.LeftRight_Line[i].GetComponent<Line_Info> ().Is_on () != Global.map [Box.TOP, Global.LEFTRIGHT, i])
					return false;
			}
			for (int i = 0; i < 9; i++) {
				if (b.RightLeft_Line [i].GetComponent<Line_Info> ().Is_on () != Global.map [Box.TOP, Global.RIGHTLEFT, i])
					return false;
			}
			break;
		case Box.LEFT:
			int[] tmpLeft1 = new int[]{ 8, 4, 0, 9, 5, 1, 10, 6, 2, 11, 7, 3 };
			for (int i = 0; i < 12; i++) {
				if (b.Row_Line [i].GetComponent<Line_Info> ().Is_on () != Global.map [Box.TOP, Global.COLUMN, tmpLeft1 [i]])
					return false;
			}

			int[] tmpLeft2 = new int[]{ 9, 6, 3, 0, 10, 7, 4, 1, 11, 8, 5, 2 };
			for (int i = 0; i < 12; i++) {
				if (b.Column_Line [i].GetComponent<Line_Info> ().Is_on () != Global.map [Box.TOP, Global.ROW, tmpLeft2 [i]])
					return false;
			}

			int[] tmpLeft3 = new int[]{ 6, 3, 0, 7, 4, 1, 8, 5, 2 };
			for (int i = 0; i < 9; i++) {
				if (b.LeftRight_Line [i].GetComponent<Line_Info> ().Is_on () != Global.map [Box.TOP, Global.RIGHTLEFT, tmpLeft3[i]])
					return false;
			}
				
			for (int i = 0; i < 9; i++) {
				if (b.RightLeft_Line [i].GetComponent<Line_Info> ().Is_on () != Global.map [Box.TOP, Global.LEFTRIGHT, tmpLeft3[i]])
					return false;
			}
			
			break;
		case Box.RIGHT:
			int[] tmpRight1 = new int[]{ 3, 7, 11, 2, 6, 10, 1, 5, 9, 0, 4, 8 };
			for (int i = 0; i < 12; i++) {
				if (b.Row_Line [i].GetComponent<Line_Info> ().Is_on () != Global.map [Box.TOP, Global.COLUMN, tmpRight1 [i]])
					return false;
			}

			int[] tmpRight2 = new int[]{ 2, 5, 8, 11, 1, 4, 7, 10, 0,3, 6,9 };
			for (int i = 0; i < 12; i++) {
				if (b.Column_Line [i].GetComponent<Line_Info> ().Is_on () != Global.map [Box.TOP, Global.ROW, tmpRight2 [i]])
					return false;
			}

			int[] tmpRight3 = new int[]{ 2, 5, 8, 1,4, 7, 0, 3, 6 };
			for (int i = 0; i < 9; i++) {
				if (b.LeftRight_Line [i].GetComponent<Line_Info> ().Is_on () != Global.map [Box.TOP, Global.RIGHTLEFT, tmpRight3[i]])
					return false;
			}

			for (int i = 0; i < 9; i++) {
				if (b.RightLeft_Line [i].GetComponent<Line_Info> ().Is_on () != Global.map [Box.TOP, Global.LEFTRIGHT, tmpRight3[i]])
					return false;
			}

			break;
		case Box.BACK:
			int[] tmpBack1 = new int[]{ 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
			for (int i = 0; i < 12; i++) {
				if (b.Row_Line [i].GetComponent<Line_Info> ().Is_on () != Global.map [Box.TOP, Global.ROW, tmpBack1 [i]])
					return false;
			}
			for (int i = 0; i < 12; i++) {
				if (b.Column_Line [i].GetComponent<Line_Info> ().Is_on () != Global.map [Box.TOP, Global.COLUMN, tmpBack1 [i]])
					return false;
			}
			int[] tmpBack2 = new int[]{ 8,7,6,5,4,3,2,1,0};
			for (int i = 0; i < 9; i++) {
				if (b.LeftRight_Line [i].GetComponent<Line_Info> ().Is_on () != Global.map [Box.TOP, Global.LEFTRIGHT, tmpBack2[i]])
					return false;
			}
			for (int i = 0; i < 9; i++) {
				if (b.RightLeft_Line [i].GetComponent<Line_Info>().Is_on() != Global.map [Box.TOP, Global.RIGHTLEFT, tmpBack2[i]])
					return false;
			}
			break;
		}
		return true;
	}

	public void OnClick ()
	{
		if (!onRotate&&!Box.IsRotating()) {
			
			onRotate = true;
			surfaces = Box.GetSurfaces ();
			Box.ToggleRotate ();
			if (!topView) {
				
				GameObject.Find ("TopSurface").GetComponent<Add_point_line> ().disable_all ();
				GameObject.Find ("FrontSurface").GetComponent<Add_point_line> ().disable_all ();
				GameObject.Find ("LeftSurface").GetComponent<Add_point_line> ().disable_all ();
				GameObject.Find ("RightSurface").GetComponent<Add_point_line> ().disable_all ();
				GameObject.Find ("BackSurface").GetComponent<Add_point_line> ().disable_all ();
			}

		}
	}
}
