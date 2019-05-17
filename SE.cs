using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SE : MonoBehaviour {

	private AudioSource sound01;
	private AudioSource sound02;

	// Use this for initialization
	void Start () {

		AudioSource[] audioSources = GetComponents<AudioSource> ();
		sound01 = audioSources [0];
		sound02 = audioSources [1];

	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKeyDown (KeyCode.Space)) {
			sound01.PlayOneShot (sound01.clip);
		}
		if (Player.flg == 1) {
			sound02.PlayOneShot (sound02.clip);
		}

	}
		
}
