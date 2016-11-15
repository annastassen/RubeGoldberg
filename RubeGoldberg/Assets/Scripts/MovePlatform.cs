using UnityEngine;
using System.Collections;

public class MovePlatform : MonoBehaviour {

	private Vector3 destination;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(KeyCode.Space)){

			transform.position = new Vector3(transform.position.x, -3.0f, transform.position.z);

		}

	}
}

