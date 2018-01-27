using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public static int shots = 0;
	public static int hits = 0;

	public static int ammo = 40;


	public GameObject scoreCanvas;

	public Text scoreText;
	public Text ammoText;
	
	// Update is called once per frame
	void Update () {
		if (shots > 0) {
			scoreCanvas.SetActive (true);
			float hitPCT = hits / (float)shots * 100;
			hitPCT = Mathf.RoundToInt (hitPCT);
			scoreText.text = hits + " / " + shots + " : " + hitPCT + "%";

			float currentAmmo = ammo - shots;

			if (currentAmmo <= 0) {
				currentAmmo = ammo;
			}

			ammoText.text = currentAmmo + " / " + ammo;



		} else {
			scoreCanvas.SetActive (false);
		}
	}


}
