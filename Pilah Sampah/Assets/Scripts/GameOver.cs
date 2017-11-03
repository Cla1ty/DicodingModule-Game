using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {
	float timer = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if (timer > 2) {
			Data.score = 0;
			SceneManager.LoadScene ("Gameplay", LoadSceneMode.Single);
		}
	}
}
