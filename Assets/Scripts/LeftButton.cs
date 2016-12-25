using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftButton : MonoBehaviour
{
	private int process;
	private const int maxProcess = 20;

	private bool onRotate;
	private Transform boxTransform;

	// Use this for initialization
	void Start ()
	{
		process = 0;
		onRotate = false;
		boxTransform =GameObject.Find ("Box").GetComponent<Transform> ();
	}

	// Update is called once per frame
	void Update ()
	{
		if (onRotate) {
			boxTransform.transform.Rotate (0, 90f / maxProcess, 0, Space.World);
			process++;
			if (process == maxProcess) {
				onRotate = false;
				process = 0;
				Box.ToggleRotate ();
			}
		}
	}

	public void OnClick ()
	{
		if (!onRotate&&!Box.IsRotating()) {
			onRotate = true;
			Box.TurnLeft ();
			Box.ToggleRotate ();
		}
	}
}
