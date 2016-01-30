using UnityEngine;
using System.Collections;

public class CameraTargetTransform : MonoBehaviour {
    
    public Transform playerTransform;

    // Use this for initialization
    void Start ()
    {

	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.position = playerTransform.position + (transform.forward * -5);
    }
}
