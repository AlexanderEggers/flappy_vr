using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	Vector3 forceUp = new Vector3(0, 200, 0);
	Vector3 defaultPos = new Vector3(0, 0, 0);
	Rigidbody playerRigidbody;

	// Use this for initialization
	void Start () {
		playerRigidbody = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {

			playerRigidbody.velocity = defaultPos;
			playerRigidbody.AddForce (forceUp);
		}
	}
}
