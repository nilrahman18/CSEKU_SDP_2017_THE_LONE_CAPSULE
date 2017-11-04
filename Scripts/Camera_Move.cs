using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Camera_Move : MonoBehaviour {

	public Transform LookAt;

	public Virtual_Joystick Joystick;

	private float Distance = 10.0f;
	private float CurrentX = 0.0f;
	private float CurrentY = 0.0f;
	private float SensitivityX = 0.7f;
	private float SensitivityY = 0.7f;

	// Update is called once per frame
	private void Update () {

		CurrentY += Joystick.Vertical() * SensitivityY;

	}

	private void LateUpdate()
	{

		Vector3 Direction = new Vector3 (0, 0, -Distance);
		Quaternion Rotation = Quaternion.Euler (CurrentY, CurrentX, 0);
		transform.position = LookAt.position + Rotation * Direction;
		transform.LookAt (LookAt);

	}

}
