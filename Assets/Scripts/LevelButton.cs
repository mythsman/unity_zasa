using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
		
	public static void SetLevel(int level){
		Global.level = level;
		Global.clear ();
		switch (level) {
		case 1:
			Global.minStep = 0;
			Global.map [Box.TOP, Global.LEFTRIGHT, 4] = true;
			break;
		case 2:
			Global.minStep = 0;
			Global.map [Box.TOP, Global.ROW, 4] = true;
			Global.map [Box.TOP, Global.ROW, 7] = true;
			Global.map [Box.TOP, Global.COLUMN, 5] = true;
			Global.map [Box.TOP, Global.COLUMN, 6] = true;

			break;
		case 3:
			Global.minStep = 0;
			Global.map [Box.TOP, Global.ROW, 0] = true;
			Global.map [Box.TOP, Global.ROW,3] = true;
			Global.map [Box.TOP, Global.COLUMN, 0] = true;
			Global.map [Box.TOP, Global.COLUMN, 1] = true;
			Global.map [Box.TOP, Global.COLUMN, 4] = true;
			Global.map [Box.TOP, Global.LEFTRIGHT, 3] = true;

			Global.map [Box.LEFT, Global.ROW, 0] = true;
			Global.map [Box.LEFT, Global.ROW, 1] = true;

			Global.map [Box.BACK, Global.ROW, 2] = true;
			break;
		case 4:
			Global.minStep = 0;
			Global.map [Box.TOP, Global.ROW, 4] = true;
			Global.map [Box.TOP, Global.ROW, 7] = true;
			Global.map [Box.TOP, Global.ROW, 9] = true;
			Global.map [Box.TOP, Global.ROW, 10] = true;
			Global.map [Box.TOP, Global.ROW, 11] = true;

			Global.map [Box.TOP, Global.COLUMN, 8] = true;
			Global.map [Box.TOP, Global.COLUMN, 9] = true;
			Global.map [Box.TOP, Global.COLUMN, 10] = true;
			Global.map [Box.TOP, Global.COLUMN, 11] = true;

			Global.map [Box.TOP, Global.LEFTRIGHT, 5] = true;
			Global.map [Box.TOP, Global.RIGHTLEFT, 3] = true;

			Global.map [Box.FRONT, Global.ROW, 0] = true;
			Global.map [Box.FRONT, Global.ROW, 1] = true;
			Global.map [Box.FRONT, Global.ROW, 2] = true;

			Global.map [Box.LEFT, Global.ROW, 2] = true;
			Global.map [Box.RIGHT, Global.ROW, 0] = true;
			break;
		case 5:
			Global.minStep = 0;
			Global.map [Box.TOP, Global.ROW, 1] = true;
			Global.map [Box.TOP, Global.ROW, 2] = true;
			Global.map [Box.TOP, Global.ROW, 3] = true;
			Global.map [Box.TOP, Global.ROW, 4] = true;
			Global.map [Box.TOP, Global.ROW, 9] = true;
			Global.map [Box.TOP, Global.ROW, 10] = true;

			Global.map [Box.TOP, Global.COLUMN, 3] = true;
			Global.map [Box.TOP, Global.COLUMN, 4] = true;
			Global.map [Box.TOP, Global.COLUMN, 6] = true;
			Global.map [Box.TOP, Global.COLUMN, 7] = true;
			Global.map [Box.TOP, Global.COLUMN, 8] = true;
			Global.map [Box.TOP, Global.COLUMN, 10] = true;

			Global.map [Box.TOP, Global.LEFTRIGHT, 3] = true;
			Global.map [Box.TOP, Global.LEFTRIGHT, 7] = true;

			Global.map [Box.TOP, Global.RIGHTLEFT, 0] = true;
			Global.map [Box.TOP, Global.RIGHTLEFT, 2] = true;
			Global.map [Box.TOP, Global.RIGHTLEFT, 4] = true;
			Global.map [Box.TOP, Global.RIGHTLEFT, 6] = true;
			Global.map [Box.TOP, Global.RIGHTLEFT, 8] = true;

			Global.map [Box.FRONT, Global.ROW, 0] = true;
			Global.map [Box.FRONT, Global.ROW, 1] = true;

			Global.map [Box.LEFT, Global.ROW, 1] = true;
			Global.map [Box.LEFT, Global.ROW, 2] = true;

			Global.map [Box.BACK, Global.ROW, 0] = true;
			Global.map [Box.BACK, Global.ROW, 1] = true;

			Global.map [Box.RIGHT, Global.ROW, 1] = true;
			Global.map [Box.RIGHT, Global.ROW, 2] = true;
		
			break;
		case 6:
			Global.minStep = 1;
			Global.map [Box.TOP, Global.LEFTRIGHT, 4] = true;
			Global.map [Box.TOP, Global.RIGHTLEFT, 4] = true;

			break;
		case 7:
			Global.minStep = 1;
			Global.map [Box.TOP, Global.LEFTRIGHT, 1] = true;
			Global.map [Box.TOP, Global.LEFTRIGHT, 2] = true;
			Global.map [Box.TOP, Global.LEFTRIGHT, 3] = true;
			Global.map [Box.TOP, Global.LEFTRIGHT, 5] = true;
			Global.map [Box.TOP, Global.LEFTRIGHT, 6] = true;
			Global.map [Box.TOP, Global.LEFTRIGHT, 7] = true;

			Global.map [Box.TOP, Global.RIGHTLEFT, 0] = true;
			Global.map [Box.TOP, Global.RIGHTLEFT, 1] = true;
			Global.map [Box.TOP, Global.RIGHTLEFT, 3] = true;
			Global.map [Box.TOP, Global.RIGHTLEFT, 5] = true;
			Global.map [Box.TOP, Global.RIGHTLEFT, 7] = true;
			Global.map [Box.TOP, Global.RIGHTLEFT, 8] = true;
			break;
		case 8:
			Global.minStep = 3;
			Global.map [Box.TOP, Global.ROW, 3] = true;
			Global.map [Box.TOP, Global.ROW, 5] = true;
			Global.map [Box.TOP, Global.ROW, 10] = true;

			Global.map [Box.TOP, Global.LEFTRIGHT, 6] = true;
			Global.map [Box.TOP, Global.RIGHTLEFT, 8] = true;

			Global.map [Box.FRONT, Global.ROW, 1] = true;
			break;
		case 9:
			Global.minStep = 3;
			Global.map [Box.TOP, Global.ROW, 3] = true;
			Global.map [Box.TOP, Global.ROW, 4] = true;
			Global.map [Box.TOP, Global.ROW, 5] = true;
			Global.map [Box.TOP, Global.ROW, 6] = true;
			Global.map [Box.TOP, Global.ROW, 7] = true;
			Global.map [Box.TOP, Global.ROW, 8] = true;

			Global.map [Box.TOP, Global.COLUMN, 1] = true;
			Global.map [Box.TOP, Global.COLUMN, 2] = true;
			Global.map [Box.TOP, Global.COLUMN, 5] = true;
			Global.map [Box.TOP, Global.COLUMN, 6] = true;
			Global.map [Box.TOP, Global.COLUMN, 9] = true;
			Global.map [Box.TOP, Global.COLUMN, 10] = true;
			break;
		case 10:
			Global.minStep = 2;
			Global.map [Box.TOP, Global.ROW, 4] = true;
			Global.map [Box.TOP, Global.ROW, 7] = true;
			Global.map [Box.TOP, Global.ROW, 11] = true;

			Global.map [Box.TOP, Global.COLUMN, 5] = true;
			Global.map [Box.TOP, Global.COLUMN, 6] = true;
			Global.map [Box.TOP, Global.COLUMN, 11] = true;

			Global.map [Box.TOP, Global.LEFTRIGHT, 5] = true;
			Global.map [Box.TOP, Global.LEFTRIGHT, 7] = true;
			Global.map [Box.TOP, Global.LEFTRIGHT, 8] = true;

			Global.map [Box.FRONT, Global.ROW, 2] = true;

			Global.map [Box.RIGHT, Global.ROW, 0] = true;
			break;
		case 11:
			Global.minStep = 2;
			Global.map [Box.TOP, Global.ROW, 11] = true;

			Global.map [Box.TOP, Global.COLUMN, 11] = true;

			Global.map [Box.TOP, Global.RIGHTLEFT, 2] = true;
			Global.map [Box.TOP, Global.RIGHTLEFT, 6] = true;
			Global.map [Box.TOP, Global.RIGHTLEFT, 8] = true;

			Global.map [Box.FRONT, Global.ROW, 2] = true;

			Global.map [Box.RIGHT, Global.ROW, 0] = true;

			break;
		case 12:
			Global.minStep = 0;
			Global.map [Box.TOP, Global.ROW, 4] = true;
			Global.map [Box.TOP, Global.ROW, 5] = true;

			Global.map [Box.TOP, Global.COLUMN, 5] = true;
			Global.map [Box.TOP, Global.COLUMN, 9] = true;

			Global.map [Box.FRONT, Global.ROW, 3] = true;
			Global.map [Box.FRONT, Global.ROW, 4] = true;
			Global.map [Box.FRONT, Global.ROW, 5] = true;

			Global.map [Box.FRONT, Global.RIGHTLEFT, 0] = true;

			Global.map [Box.RIGHT, Global.ROW, 3] = true;
			Global.map [Box.RIGHT, Global.ROW, 4] = true;
			Global.map [Box.RIGHT, Global.ROW, 5] = true;

			Global.map [Box.RIGHT, Global.LEFTRIGHT, 2] = true;

			break;
		case 13:
			Global.minStep = 0;
			Global.map [Box.TOP, Global.ROW, 8] = true;
			Global.map [Box.TOP, Global.ROW, 11] = true;
			Global.map [Box.TOP, Global.COLUMN, 10] = true;
			Global.map [Box.TOP, Global.COLUMN, 11] = true;

			Global.map [Box.FRONT, Global.ROW, 2] = true;
			Global.map [Box.FRONT, Global.ROW, 5] = true;
			Global.map [Box.FRONT, Global.COLUMN, 2] = true;

			Global.map [Box.RIGHT, Global.ROW, 0] = true;
			Global.map [Box.RIGHT, Global.ROW, 3] = true;
			Global.map [Box.RIGHT, Global.COLUMN, 1] = true;

			break;
		case 14:
			Global.minStep = 0;
			Global.map [Box.TOP, Global.ROW, 5] = true;
			Global.map [Box.TOP, Global.ROW, 7] = true;

			Global.map [Box.TOP, Global.COLUMN, 6] = true;
			Global.map [Box.TOP, Global.COLUMN, 9] = true;
			Global.map [Box.TOP, Global.LEFTRIGHT, 4] = true;

			Global.map [Box.FRONT, Global.ROW, 10] = true;
			Global.map [Box.FRONT, Global.COLUMN, 4] = true;
			Global.map [Box.FRONT, Global.LEFTRIGHT, 6] = true;
			Global.map [Box.FRONT, Global.RIGHTLEFT, 0] = true;
			Global.map [Box.FRONT, Global.RIGHTLEFT, 8] = true;

			Global.map [Box.LEFT, Global.COLUMN, 7] = true;

			Global.map [Box.BACK, Global.COLUMN, 4] = true;

			Global.map [Box.RIGHT, Global.ROW, 10] = true;
			Global.map [Box.RIGHT, Global.COLUMN, 7] = true;
			Global.map [Box.RIGHT, Global.LEFTRIGHT, 2] = true;
			Global.map [Box.RIGHT, Global.LEFTRIGHT, 6] = true;
			Global.map [Box.RIGHT, Global.RIGHTLEFT,8] = true;

			break;
		case 15:
			Global.minStep = 0;
			Global.map [Box.TOP, Global.ROW, 6] = true;
			Global.map [Box.TOP, Global.ROW, 7] = true;
			Global.map [Box.TOP, Global.ROW, 8] = true;
			Global.map [Box.TOP, Global.COLUMN,11] = true;
			Global.map [Box.TOP, Global.LEFTRIGHT, 6] = true;

			Global.map [Box.FRONT, Global.ROW, 5] = true;
			Global.map [Box.FRONT, Global.COLUMN, 1] = true;
			Global.map [Box.FRONT, Global.COLUMN, 3] = true;
			Global.map [Box.FRONT, Global.COLUMN, 5] = true;
			Global.map [Box.FRONT, Global.COLUMN, 7] = true;
			Global.map [Box.FRONT, Global.RIGHTLEFT,4] = true;

			Global.map [Box.RIGHT, Global.ROW, 0] = true;
			Global.map [Box.RIGHT, Global.ROW, 6] = true;
			Global.map [Box.RIGHT, Global.COLUMN, 0] = true;
			Global.map [Box.RIGHT, Global.COLUMN, 4] = true;
			Global.map [Box.RIGHT, Global.LEFTRIGHT, 3] = true;


			break;
		case 16:
			Global.minStep = 3;
			Global.map [Box.FRONT, Global.ROW, 4] = true;
			Global.map [Box.FRONT, Global.ROW, 7] = true;
			Global.map [Box.FRONT, Global.COLUMN,5] = true;
			Global.map [Box.FRONT, Global.COLUMN,6] = true;

			Global.map [Box.LEFT, Global.ROW, 4] = true;
			Global.map [Box.LEFT, Global.ROW, 7] = true;
			Global.map [Box.LEFT, Global.COLUMN,5] = true;
			Global.map [Box.LEFT, Global.COLUMN,6] = true;

			Global.map [Box.BACK, Global.ROW, 4] = true;
			Global.map [Box.BACK, Global.ROW, 7] = true;
			Global.map [Box.BACK, Global.COLUMN,5] = true;
			Global.map [Box.BACK, Global.COLUMN,6] = true;

			Global.map [Box.RIGHT, Global.ROW, 4] = true;
			Global.map [Box.RIGHT, Global.ROW, 7] = true;
			Global.map [Box.RIGHT, Global.COLUMN,5] = true;
			Global.map [Box.RIGHT, Global.COLUMN,6] = true;
			break;
		case 17:
			Global.minStep = 2;
			Global.map [Box.FRONT, Global.LEFTRIGHT, 0] = true;
			Global.map [Box.FRONT, Global.LEFTRIGHT, 4] = true;
			Global.map [Box.FRONT, Global.LEFTRIGHT, 8] = true;
			Global.map [Box.RIGHT, Global.ROW, 9] = true;
			Global.map [Box.RIGHT, Global.ROW, 10] = true;
			Global.map [Box.RIGHT, Global.ROW, 11] = true;

			Global.map [Box.TOP, Global.COLUMN, 0] = true;
			Global.map [Box.TOP, Global.COLUMN, 4] = true;
			Global.map [Box.TOP, Global.COLUMN, 8] = true;

			Global.map [Box.BACK, Global.RIGHTLEFT, 2] = true;
			Global.map [Box.BACK, Global.RIGHTLEFT, 4] = true;
			Global.map [Box.BACK, Global.RIGHTLEFT, 6] = true;

			Global.map [Box.LEFT, Global.ROW, 0] = true;
			Global.map [Box.LEFT, Global.ROW, 1] = true;
			Global.map [Box.LEFT, Global.ROW, 2] = true;

			break;
		case 18:
			Global.minStep = 2;
			Global.map [Box.TOP, Global.ROW, 10] = true;
			Global.map [Box.TOP, Global.LEFTRIGHT, 3] = true;
			Global.map [Box.TOP, Global.LEFTRIGHT, 8] = true;
			Global.map [Box.TOP, Global.RIGHTLEFT, 5] = true;
			Global.map [Box.TOP, Global.RIGHTLEFT, 6] = true;

			Global.map [Box.FRONT, Global.ROW, 1] = true;

			break;
		case 19:
			
			Global.minStep = 2;
			Global.map [Box.TOP, Global.COLUMN,5] = true;
			Global.map [Box.TOP, Global.COLUMN,9] = true;
			Global.map [Box.TOP, Global.LEFTRIGHT,0] = true;
			Global.map [Box.TOP, Global.RIGHTLEFT,1] = true;
			break;
		case 20:
			Global.minStep = 0;
			Global.map [Box.TOP, Global.ROW,9] = true;
			Global.map [Box.TOP, Global.ROW,10] = true;
			Global.map [Box.TOP, Global.ROW,11] = true;
			Global.map [Box.TOP, Global.COLUMN,3] = true;
			Global.map [Box.TOP, Global.COLUMN,7] = true;
			Global.map [Box.TOP, Global.COLUMN,11] = true;
			Global.map [Box.TOP, Global.RIGHTLEFT,2] = true;
			Global.map [Box.TOP, Global.RIGHTLEFT,4] = true;
			Global.map [Box.TOP, Global.RIGHTLEFT,6] = true;

			Global.map [Box.FRONT, Global.ROW,0] = true;
			Global.map [Box.FRONT, Global.ROW,1] = true;
			Global.map [Box.FRONT, Global.ROW,2] = true;
			Global.map [Box.FRONT, Global.COLUMN,3] = true;
			Global.map [Box.FRONT, Global.COLUMN,7] = true;
			Global.map [Box.FRONT, Global.COLUMN,11] = true;

			Global.map [Box.FRONT, Global.LEFTRIGHT,0] = true;
			Global.map [Box.FRONT, Global.LEFTRIGHT,4] = true;
			Global.map [Box.FRONT, Global.LEFTRIGHT,8] = true;
			Global.map [Box.RIGHT, Global.ROW,0] = true;
			Global.map [Box.RIGHT, Global.ROW,1] = true;
			Global.map [Box.RIGHT, Global.ROW,2] = true;
			Global.map [Box.RIGHT, Global.COLUMN,0] = true;
			Global.map [Box.RIGHT, Global.COLUMN,4] = true;
			Global.map [Box.RIGHT, Global.COLUMN,8] = true;
			Global.map [Box.RIGHT, Global.LEFTRIGHT,0] = true;
			Global.map [Box.RIGHT, Global.LEFTRIGHT,4] = true;
			Global.map [Box.RIGHT, Global.LEFTRIGHT,8] = true;
			break;
		}
	}
	public void LevelOnClick(int level){
		SetLevel (level);
		SceneManager.LoadScene ("Zasa");
	}
}
