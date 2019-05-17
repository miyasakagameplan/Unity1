using UnityEngine;
using System.Collections;

public class ShakeCamera : MonoBehaviour {
	public float setShakeTIme;

	private float lifeTime;
	private Vector3 savePosition;
	private float lowRangeX;
	private float maxRangeX;
	private float lowRangeY;
	private float maxRangeY;
	//private float lowRangeZ;
	//private float maxRangeZ;

	void CatchShake(){
		savePosition = transform.position;
		lowRangeX = savePosition.x - 1.0f/4;
		maxRangeX = savePosition.x + 1.0f/4;
		lowRangeY = savePosition.y - 1.0f/4;
		maxRangeY = savePosition.y + 1.0f/4;
		//lowRangeZ = savePosition.z - 1.0f;
		//maxRangeZ = savePosition.z + 1.0f;
		lifeTime = setShakeTIme;
	}

	void Start(){
		if (setShakeTIme <= 0.0f) {
			setShakeTIme = 0.7f/2;
			lifeTime = 0.0f;
		}
	}

	void Update(){
		
		if(lifeTime < 0.0f){
			transform.position =savePosition;
			lifeTime = 0.0f;
		}
		if(lifeTime > 0.0f){
			lifeTime -= Time.deltaTime;
			float x_val = Random.Range (lowRangeX, maxRangeX);
			float y_val = Random.Range (lowRangeY, maxRangeY);
			//float z_val = Random.Range (lowRangeZ, maxRangeZ);
			transform.position = new Vector3(x_val,y_val,transform.position.z);
		}
		if (gFade.startFlg == 1) {
			if (Player.flg == 1) {
				CatchShake ();
			}
		}
	}
}
