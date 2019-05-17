using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.SceneManagement;

public class gFade : MonoBehaviour {

	float fadeSpeed = 0.01f;        
	float red, green, blue, alfa;  

	public bool isgFadeOut = false; 
	public bool isgFadeIn = false;   
	public static float startFlg = 0;

	Image fadeImage;               

	void Start () {
		fadeImage = GetComponent<Image> ();
		red = fadeImage.color.r;
		green = fadeImage.color.g;
		blue = fadeImage.color.b;
		alfa = fadeImage.color.a;
		isgFadeIn = true;
	}

	void Update () {

		if (Count.count >= 100) {
			isgFadeOut = true;
		}
		if (Life.life <= 0) {
			isgFadeOut = true;
		}

		if (isgFadeIn) {
			StartFadeIn ();
		}

		if (isgFadeOut) {
			StartFadeOut ();
		}
	}


	void StartFadeIn(){
		alfa -= fadeSpeed;                
		SetAlpha ();                      
		if(alfa <= 0){                    
			isgFadeIn = false;             
			fadeImage.enabled = false; 
			startFlg = 1;
		}
	}

	void StartFadeOut(){
		startFlg = 0;
		fadeImage.enabled = true;  
		alfa += fadeSpeed;         
		SetAlpha ();               
		if(alfa >= 1){             
			isgFadeOut = false;
			SceneManager.LoadScene ("Result");
		}
	}

	void SetAlpha(){
		fadeImage.color = new Color(red, green, blue, alfa);
	}
}
