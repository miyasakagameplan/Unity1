using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Count : MonoBehaviour{

	public static float count;

	public static float auto;

	float minus;

	Text text;

	void Start (){

		count = 0;

		text = GetComponent<Text>();

		auto = Time.deltaTime;
	}

	void Update (){
		if(gFade.startFlg == 1){
		count += auto;
		}
		text.text = "Distance" + ":" + count + "m" ;

		if (count >= 100) {
			minus = count - 100;
			count = count - minus;
			auto = 0;
			count += auto;
			SceneManager.LoadScene ("Result");
		}
	}
}
