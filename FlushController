using UnityEngine;
using UnityEngine.UI;

public class FlushController : MonoBehaviour {

	Image img;

	// Use this for initialization
	void Start () {
		img = GetComponent<Image> ();
		img.color = Color.clear;

	}

	// Update is called once per frame
	void Update () {
		if (gFade.startFlg == 1) {
			if (Player.flg == 1) {
				this.img.color = new Color (1f, 0f, 0f, 0.5f);
				Player.flg = 0;
			} else {
				this.img.color = Color.Lerp (this.img.color, Color.clear, Time.deltaTime);
			}
		}
	}
}
