using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiddleButton : MonoBehaviour
{
	private bool topView;
	private bool onRotate;
	private int process;
	private const int maxProcess = 20;
	private Transform cameraTransform;
	private Camera cameraCamera;
	private ArrayList surfaces;

	// Use this for initialization
	void Start ()
	{
		topView = false;
		onRotate = false;
		process = 0;
		cameraTransform = GameObject.Find ("Main Camera").GetComponent<Transform> ();
		cameraCamera = GameObject.Find ("Main Camera").GetComponent<Camera> ();

	}

	// Update is called once per frame
	void Update ()
	{
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
					topView = false;
					onRotate = false;
					process = 0;
					Box.ToggleRotate ();
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
					topView = true;
					onRotate = false;
					process = 0;
					Box.ToggleRotate ();
				}
			}
		}
	}

	public void OnClick ()
	{
		if (!onRotate&&!Box.IsRotating()) {
			onRotate = true;
			surfaces = Box.GetSurfaces ();
			Box.ToggleRotate ();
		}
	}
}
