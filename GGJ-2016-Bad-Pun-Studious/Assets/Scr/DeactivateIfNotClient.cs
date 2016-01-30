using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Networking;

public class DeactivateIfNotClient : NetworkBehaviour {

    public List<GameObject> objectsToRemove = new List<GameObject>();

    // Use this for initialization
    void Start()
    {
    }
	
	// Update is called once per frame
	void Update () {
        foreach (GameObject currentObject in objectsToRemove)
        {
            currentObject.SetActive(isLocalPlayer);
        }
	}
}
