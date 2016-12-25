using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level1Button : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnClick(){
		Global.level = 1;
		Global.map = new bool[5,17,17];
		Global.map [Box.TOP, 1, 2] = true;
		Global.map [Box.TOP, 1, 5] = true;
		Global.map [Box.TOP, 2, 6] = true;
		Global.map [Box.TOP, 5, 6] = true;
		Global.map [Box.TOP, 5, 9] = true;
		Global.map [Box.TOP, 5, 10] = true;

		Global.map [Box.LEFT, 1, 2] = true;
		Global.map [Box.LEFT, 2, 3] = true;

		Global.	map [Box.BACK, 3, 4] = true;

		for (int i = 0; i < 5; i++) {
			for (int j = 1; j < 17; j++) {
				for (int k = 1; k < 17; k++) {
					if (j > k) {
						Global.map [i, j, k] = Global.map [i, k, j];
					}
				}
			}
		}
		SceneManager.LoadScene ("Zasa");
	}
}
