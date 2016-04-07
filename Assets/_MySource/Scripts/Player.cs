using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	Vector3 forceUp = new Vector3(0, 300, 0);
	Vector3 defaultPos = new Vector3(0, 0, 0);
	Rigidbody playerRigidbody;
    Animator animator;

	// Use this for initialization
	void Start () {
		playerRigidbody = GetComponent<Rigidbody> ();
        animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
            animator.SetBool("fly", true);
			playerRigidbody.velocity = defaultPos;
			playerRigidbody.AddForce (forceUp);
		}
	}

	void OnCollisionEnter(Collision collision) {
		Die ();
	}

	void Die() {
		Application.LoadLevel (Application.loadedLevel);
	}
}
