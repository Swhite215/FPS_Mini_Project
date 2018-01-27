using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drone : MonoBehaviour {

	public float acceptableDistance;
	public int speed = 0;
	public Transform[] positions;

	private Transform moveToPoint;
	private int positionIndex = 0;

	// Use this for initialization
	void Start () {
		moveToPoint = positions [positionIndex];
	}
	
	// Update is called once per frame
	void Update() {

		float dist = Vector3.Distance (moveToPoint.position, transform.position);
		//print ("Distance to other: " + dist);

		if (positionIndex == 0) {
			adjustTracking(dist);
		} else if (positionIndex == 1) {
			adjustTracking(dist);
		} else if (positionIndex == 2) {
			adjustTracking(dist);
		} else if (positionIndex == 3) {
			adjustTracking(dist);
		}

	}

	void adjustTracking(float dist) {
		transform.Translate (Vector3.down * Time.deltaTime * speed);

		if (dist <= acceptableDistance) {
			transform.Rotate (Vector3.up, 90f, Space.World);

			if (positionIndex == 3) {
				positionIndex = 0;
			} else {
				positionIndex++;
			}

			moveToPoint = positions [positionIndex];
		}
	}

	void OnTriggerEnter(Collider other) {
		if (other.tag == "Shot") {
			Destroy (gameObject);
		}
	}
}
