using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floating_Blocks_Vertical : MonoBehaviour {

	public float delta = 1.5f;  // Amount To Move left And Right From The Start Point
	public float speed = 2.0f;  // Amount Of Speed To Give To The Block
	private Vector3 startPos;

	void Start () {
		startPos = transform.position;	//Giving The Three Dimensional Position To The Object
	}

	void Update () {
		Vector3 v = startPos;			//Another Vector Object To Calculate The Position Changes In Each Frame
		v.y += delta * Mathf.Sin (Time.time * speed);	//The Movement Along The X Axis
		transform.position = v;			//Assigning The New Position To The Updated Position in Every Frame
	}

}
