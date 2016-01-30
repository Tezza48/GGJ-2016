using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Networking;

public class NetworkManagerOverride : NetworkManager {
    public GameObject ghostPrefab;

    public override void OnServerAddPlayer(NetworkConnection conn, short playerControllerId)
    {
        GameObject newPlayerPrefab;

        var tempPlayer = GameObject.FindGameObjectWithTag("Player");

        if (tempPlayer == null)
        {
            newPlayerPrefab = playerPrefab;
        }
        else
        {
            newPlayerPrefab = ghostPrefab;
        }

        var player = (GameObject)GameObject.Instantiate(newPlayerPrefab, Vector3.zero, Quaternion.identity);
        NetworkServer.AddPlayerForConnection(conn, player, playerControllerId);
    }
}
