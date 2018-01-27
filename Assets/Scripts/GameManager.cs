using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public static int shots = 0;
	public static int hits = 0;

	public GameObject scoreCanvas;

	public Text scoreText;
	
	// Update is called once per frame
	void Update () {
		if (shots > 0) {
			scoreCanvas.SetActive (true);
			float hitPCT = hits / (float)shots * 100;
			hitPCT = Mathf.RoundToInt (hitPCT);
			scoreText.text = hits + " / " + shots + " : " + hitPCT + "%";
		} else {
			scoreCanvas.SetActive (false);
		}
	}


}
