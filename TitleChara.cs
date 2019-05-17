using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleChara : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Rotate(0 * Time.deltaTime, 0 * Time.deltaTime, -50 * Time.deltaTime);
	}
}
