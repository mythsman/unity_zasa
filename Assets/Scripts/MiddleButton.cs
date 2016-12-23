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
	private Transform frontSurfaceTransform;
	private Transform backSurfaceTransform;
	private Transform topSurfaceTransform;
	private Transform downSurfaceTransform;
	private Transform leftSurfaceTransform;
	private Transform rightSurfaceTransform;


	// Use this for initialization
	void Start ()
	{
		topView = false;
		onRotate = false;
		process = 0;
		cameraTransform = GameObject.Find ("Main Camera").GetComponent<Transform> ();
		frontSurfaceTransform = GameObject.Find ("Box/FrontSurface").GetComponent<Transform>();
		backSurfaceTransform = GameObject.Find ("Box/BackSurface").GetComponent<Transform>();
		topSurfaceTransform = GameObject.Find ("Box/TopSurface").GetComponent<Transform>();
		downSurfaceTransform = GameObject.Find ("Box/DownSurface").GetComponent<Transform>();
		leftSurfaceTransform = GameObject.Find ("Box/LeftSurface").GetComponent<Transform>();
		rightSurfaceTransform = GameObject.Find ("Box/RightSurface").GetComponent<Transform>();
	}

	// Update is called once per frame
	void Update ()
	{
		if (onRotate) {
			if (topView) {
				cameraTransform.RotateAround (new Vector3(0,-1.5f,0),new Vector3(1,0,-1	),-54.74f/maxProcess);
				cameraTransform.Rotate (0,0,-45f/maxProcess);
				 
				frontSurfaceTransform.RotateAround(new Vector3(0, 0,-1.5f),new Vector3(1,0,0),-90f/maxProcess);

				process++;
				if (process == maxProcess) {
					topView = false;
					onRotate = false;
					process = 0;
				}
			} else {
				cameraTransform.RotateAround (new Vector3(0,-1.5f,0),new Vector3(1,0,-1),54.74f/maxProcess);
				cameraTransform.Rotate (0,0,45f/maxProcess);
					
				frontSurfaceTransform.RotateAround(new Vector3(0, 0,-1.5f),new Vector3(1,0,0),90f/maxProcess);

				process++;
				if (process == maxProcess) {
					topView = true;
					onRotate = false;
					process = 0;
				}
			}
		}
	}

	public void OnClick ()
	{
		onRotate = true;
	}
}
