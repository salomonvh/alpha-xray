using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	public void ResetPosition () {
		transform.position = new Vector3(0, 1.2f, 0);
		var rigidbody = GetComponent<Rigidbody>();
		rigidbody.velocity = Vector3.zero;
    rigidbody.angularVelocity = Vector3.zero;
	}
}
