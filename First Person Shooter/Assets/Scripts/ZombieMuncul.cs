using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieMuncul : MonoBehaviour {
	[SerializeField]
	private GameObject zombie;
	private GameObject player;

	GameObject[] monsters;

	float timer = 0;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if (timer > 3f) {
			Vector3 posRecomended;
			do {
				posRecomended = new Vector3 (
					Random.Range (0, 500),
					50,
					Random.Range (0, 500)
				);
			} while(Vector3.Distance (posRecomended, player.transform.position) < 50);

			Instantiate (zombie, posRecomended, Quaternion.identity);
			timer = 0;
		}
	}
}
