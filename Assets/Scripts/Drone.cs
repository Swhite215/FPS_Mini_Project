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
		print ("Distance to other: " + dist);

		if (positionIndex == 0) {
			//Move towards first position
			transform.Translate (Vector3.down * Time.deltaTime * speed);

			if (dist <= acceptableDistance) {
				transform.Rotate (Vector3.up, 90f, Space.World);
				positionIndex++;
				moveToPoint = positions [positionIndex];
			}

		} else if (positionIndex == 1) {
			transform.Translate (Vector3.down * Time.deltaTime * speed);

			if (dist <= acceptableDistance) {
				transform.Rotate (Vector3.up, 90f, Space.World);
				positionIndex++;
				moveToPoint = positions [positionIndex];
			}
		} else if (positionIndex == 2) {
			transform.Translate (Vector3.down * Time.deltaTime * speed);

			if (dist <= acceptableDistance) {
				transform.Rotate (Vector3.up, 90f, Space.World);
				positionIndex++;
				moveToPoint = positions [positionIndex];
			}
		} else if (positionIndex == 3) {
			transform.Translate (Vector3.down * Time.deltaTime * speed);

			if (dist <= acceptableDistance) {
				transform.Rotate (Vector3.up, 90f, Space.World);
				positionIndex = 0;
				moveToPoint = positions [positionIndex];
			}
		}


		//transform.Translate(Vector3.up * Time.deltaTime, Space.World);

		//if (positionTwo) {
			//float dist = Vector3.Distance (positionTwo.position, transform.position);
			//print ("Distance to other: " + dist);
		//}

		//float dist = Vector3.Distance (positionTwo.position, transform.position);
		//print ("Distance to other: " + dist);

		//if (dist <= 3 &&  myTargetPosition == targetPositions.Down) {
			//transform.Rotate (Time.deltaTime, 90, 0);
			//myTargetPosition = targetPositions.Left;
		//}
	}
}
