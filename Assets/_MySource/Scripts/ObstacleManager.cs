using UnityEngine;
using System.Collections;

public class ObstacleManager : MonoBehaviour {
	public GameObject obstacle;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("createObstacles", 0f, 3f);
	}
	
	// Update is called once per frame
	void Update () {
	}

	void createObstacles() {
        Vector3 randomPosition = new Vector3(transform.position.x, Random.Range(-1, 3), transform.position.z);
		Instantiate (obstacle, randomPosition, Quaternion.identity);
	}
}
