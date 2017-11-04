using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving_Objects : MonoBehaviour {

	public Transform[] Moving_Points;
	private int Current_Point;
	public float Move_Speed;

	// Use this for initialization
	void Start () {

		transform.position = Moving_Points [0].position;
		Current_Point = 0;

	}
	
	// Update is called once per frame
	void Update () {

		if (transform.position == Moving_Points [Current_Point].position) 
		{
			Current_Point++;
		}

		if (Current_Point >= Moving_Points.Length) 
		{
			Current_Point = 0;
		}

		transform.position = Vector3.MoveTowards (transform.position, Moving_Points [Current_Point].position, Move_Speed * Time.deltaTime);

	}
}
