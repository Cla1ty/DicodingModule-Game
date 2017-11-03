using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MonsterMove : MonoBehaviour {
	GameObject player;
	Animator animator;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		animator = gameObject.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (animator.GetCurrentAnimatorStateInfo (0).IsName ("MatiAnim")) {
			Data.score++;
			Destroy (gameObject);
		} else {
			transform.LookAt (player.transform);
			transform.Translate (Vector3.forward * Time.deltaTime * 20f);
		}
	}

	void OnCollisionEnter(Collision collision){
		if (collision.gameObject.tag.Equals ("Player")) {
			SceneManager.LoadScene ("Gameover");
		} else if (collision.gameObject.tag.Equals ("Peluru")) {
			animator.SetBool ("tertembak", true);
		}
	}
}
