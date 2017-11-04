using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level_End : MonoBehaviour {

	private bool Trigger;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter(Collider Object)
	{
		if (Object.name == "Player") 
		{
			Trigger = true;
		}
	}

	private void OnGUI()
	{
		if (Trigger == true) 
		{
			GUI.Button (new Rect (700, 200, 200, 200), "Level Completed!!!");	//A Simple Gui To Show The Score & Points	
		}
	}
		
}
