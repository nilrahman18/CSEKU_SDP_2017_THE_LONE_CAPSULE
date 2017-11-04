using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Level_Loader : MonoBehaviour {

	public string LoadLevel;

	void OnTriggerEnter(Collider Object)
	{
		if (Object.name == ("Player")) 
		{
			SceneManager.LoadScene (LoadLevel);
		}
	}

}
