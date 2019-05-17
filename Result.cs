using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Result : MonoBehaviour {

	float Rcount = 0;

	Text Rtext;

	// Use this for initialization
	void Start () {

		Rcount = Count.count;

		Rcount = Rcount * 1;

		Rtext = GetComponent<Text>();


	}
	
	// Update is called once per frame
	void Update () {

		Rtext.text = Rcount + "m" ;

		if (Input.GetKeyDown (KeyCode.Space)) {
			//SceneManager.LoadScene ("Title");
		}
	}
}
