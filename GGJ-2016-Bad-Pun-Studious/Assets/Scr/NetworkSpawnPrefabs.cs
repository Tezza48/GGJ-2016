using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Networking;

[RequireComponent(typeof(NetworkIdentity))]
public class NetworkSpawnPrefabs : NetworkBehaviour {

    private GameObject Player;

    [SerializeField] public GameObject playerPrefab;
    [SerializeField] public GameObject ghostPrefab;

    private NetworkManager netManager;

    void Start()
    {
        netManager = GameObject.FindGameObjectWithTag("NetworkManager").GetComponent<NetworkManager>();
        

    }
	
	// Update is called once per frame
	void Update () {
	}
}
