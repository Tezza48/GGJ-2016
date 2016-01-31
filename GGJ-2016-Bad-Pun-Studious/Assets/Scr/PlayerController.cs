using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    void OnTriggerStay2D(Collider2D other)
    {

        if (Input.GetButtonDown("Use") && other.tag == "Portal")
        {
            transform.position = other.GetComponent<PortalEntrance>().exit.position;
        }
    }
}
