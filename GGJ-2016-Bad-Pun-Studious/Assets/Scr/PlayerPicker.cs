using UnityEngine;
using System.Collections;
using UnityEngine.Networking;
using System;

public class PlayerPicker : NetworkBehaviour {

    public GameObject playerPrefab;
    public GameObject ghostPrefab;

	// Use this for initialization
	void Start () {
        GameObject currentPlayer = GameObject.FindGameObjectWithTag("Player");
        if (currentPlayer == null)
        {
            Spawn(playerPrefab);
        }
        else
        {
            Spawn(ghostPrefab);
        }
    }

    private void Spawn(GameObject prefab)
    {
        GameObject playerSpawn = (GameObject)Instantiate(prefab, transform.position, Quaternion.identity);
        NetworkServer.Spawn(playerSpawn);
    }

    // Update is called once per frame
    void Update () {
	
	}
}
