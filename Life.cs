using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Life : MonoBehaviour{


	public static float life;

	Text lifepoint;

	void Start (){

		life = 3;

		lifepoint= GetComponent<Text>();
	}

	void Update (){

		lifepoint.text = "LIFE" + ":" + life ;
		if (life <= 0) {		
			life = 0;	
			Count.auto = 0;
			Count.count += Count.auto;
			//SceneManager.LoadScene ("Result");
		}
	}
}
