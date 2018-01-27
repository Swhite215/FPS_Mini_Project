using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateDrone : MonoBehaviour {

	public GameObject drone;
	private int droneCount = 0;
	public int droneMax;

	void OnTriggerEnter(Collider other) {
		if (other.tag == "Player" && droneCount == 0) {
			drone.SetActive (true);
			droneCount++;
		}
	}
}
