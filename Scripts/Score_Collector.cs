using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score_Collector : MonoBehaviour {

	public int Points = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnGUI()
	{
		GUI.Button (new Rect (10, 10, 300, 250), "Score : " + Points);	//A Simple Gui To Show The Score & Points
	}

}
