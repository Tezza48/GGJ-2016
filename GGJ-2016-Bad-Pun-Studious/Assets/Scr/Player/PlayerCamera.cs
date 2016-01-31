using UnityEngine;
using System.Collections;

public class PlayerCamera : MonoBehaviour {

    private Transform playerTransform;

	// Use this for initialization
	void Start () {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = playerTransform.position + (Vector3.back * 10);
	}
}
