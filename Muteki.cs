using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Muteki : MonoBehaviour {

	public static float muteki = 0;

	Text mutekipoint;

	// Use this for initialization
	void Start () {

		mutekipoint= GetComponent<Text>();
		
	}
	
	// Update is called once per frame
	void Update () {

		mutekipoint.text = "MUTEKI" + ":" + muteki ;
	}
}
