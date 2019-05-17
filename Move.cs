using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (gFade.startFlg == 1) {
			this.transform.Translate (0 * Time.deltaTime, 0 * Time.deltaTime, 10 * Time.deltaTime);
		}
	}
}
