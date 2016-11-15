using UnityEngine;
using System.Collections;

public class CameraTrigger : MonoBehaviour {

	//public GameObject camToActivate;
	public int camNumber;

	public CameraController controller;

	void OnTriggerEnter(Collider other){

		controller.DeactivateCameras();
		controller.activateCamera(camNumber);

	}
}