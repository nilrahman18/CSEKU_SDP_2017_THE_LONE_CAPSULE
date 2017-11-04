using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour {

	public Transform RespawnPoint;
	public GameObject Player;

	public void Update()
	{

	}

	public void OnTriggerEnter(Collider Col)
	{

		if (Col.tag == "Player") 
		{

			Debug.Log("Hello I Am Respawn");
			Player.transform.position = RespawnPoint.position;

		}

	}

}
