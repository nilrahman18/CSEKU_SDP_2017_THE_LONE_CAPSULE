using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class UnitPlayer : Unit
{

	public Joystick JOY;
	
	// Use this for initialization
	public override void Start ()
	{
		base.Start ();
	}
	
	// Update is called once per frame
	public override void Update ()
	{
		
		move = new Vector3(CrossPlatformInputManager.GetAxis("Horizontal"), 0f, CrossPlatformInputManager.GetAxis("Vertical"));
		
		move.Normalize();
		
		move = transform.TransformDirection (move);
		
		running = Input.GetKey (KeyCode.LeftShift)  || Input.GetKey (KeyCode.RightShift);
		
		base.Update ();
	}

	public void Jump()
	{

		{
			jump = true;	
		}

	}

}
