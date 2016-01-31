using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class NetworkDestroyable : NetworkBehaviour {

    [SyncVar]
    public bool destroy = false;
	
	// Update is called once per frame
	void Update () {
        if (destroy) GameObject.Destroy(gameObject);
	}
}
