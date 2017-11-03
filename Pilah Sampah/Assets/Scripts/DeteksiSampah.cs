using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeteksiSampah : MonoBehaviour {
	public string nameTag;

	public AudioClip audioBenar;
	public AudioClip audioSalah;

	private AudioSource mediaPlayerBenar;
	private AudioSource mediaPlayerSalah;

	public Text textScore;

	// Use this for initialization
	void Start () {
		mediaPlayerBenar = gameObject.AddComponent<AudioSource> ();
		mediaPlayerBenar.clip = audioBenar;

		mediaPlayerSalah = gameObject.AddComponent<AudioSource> ();
		mediaPlayerSalah.clip = audioSalah;
	}

	private void OnTriggerEnter2D(Collider2D collision){
		if (collision.tag.Equals (nameTag)) {
			Data.score += 25;
			mediaPlayerBenar.Play ();
		} else {
			Data.score -= 5;
			mediaPlayerSalah.Play ();
		}

		Destroy (collision.gameObject);
		textScore.text = Data.score.ToString ();
	}
}
