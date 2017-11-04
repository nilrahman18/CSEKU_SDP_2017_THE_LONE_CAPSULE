using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_Pickup : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (90 * Time.deltaTime, 0, 0);
	}

	private void OnTriggerEnter(Collider Object)
	{
		if (Object.name == "Player") 
		{
			Object.GetComponent<Score_Collector> ().Points+=100;	//Add Points
			Destroy (gameObject);								//Make The Coin Disapper After Collecting
		}
	}

}
