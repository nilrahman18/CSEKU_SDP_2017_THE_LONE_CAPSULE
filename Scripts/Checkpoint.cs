using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour {

	public Transform SpawnPoint;
//	public Vector3 Move;

	public void OnTriggerEnter(Collider Col)
	{

		if (Col.tag == "Player") 
		{

			SpawnPoint.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);

		}

	}

}
