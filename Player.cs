using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public static int flg = 0;

	// Use this for initialization
	void Start () {
		
	}

	void OnTriggerEnter(Collider other){	
		if (gFade.startFlg == 1) {	
			if (other.gameObject.tag == "Cube") {
				if (Muteki.muteki > 0) {
					Muteki.muteki = Muteki.muteki - 1;
				}
				if (Muteki.muteki < 1) {
					flg = 1;
					Life.life = Life.life - 1;
				}

			}
			if (other.gameObject.tag == "Item") {
				Muteki.muteki = Muteki.muteki + 1;
			}
		}
	}
		

	// Update is called once per frame
	void Update () {
		if (gFade.startFlg == 1) {
			this.transform.Translate (0 * Time.deltaTime, 0 * Time.deltaTime, 10 * Time.deltaTime);
			//transform.Translate (new Vector3 (0f, 0f, 0.3f));
		}
	}
}
