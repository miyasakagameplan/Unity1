using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageRoll : MonoBehaviour {

	public static float reroll = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Space)) {
			reroll += 1;
			if(reroll>1){
				reroll=0;
			}
		}
		if (gFade.startFlg == 1) {
			if (reroll == 0) {
				this.transform.Rotate (0 * Time.deltaTime, 0 * Time.deltaTime, 100 * Time.deltaTime);
			}

			if (reroll == 1) {
				this.transform.Rotate (0 * Time.deltaTime, 0 * Time.deltaTime, -100 * Time.deltaTime);
			}
		}
	}
}
