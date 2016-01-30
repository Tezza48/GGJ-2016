using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class NetworkManagerOverride : NetworkManager {

    ManagerMod managerMod;

    public void JoinGame()
    {
        StartClient();
    }

    public override void OnClientConnect(NetworkConnection conn)
    {
        base.OnClientConnect(conn);
    }

    public override void OnStartHost()
    {
        base.OnStartHost();
    }

    public override void OnServerAddPlayer(NetworkConnection conn, short playerControllerId)
    {
        managerMod = GetComponent<ManagerMod>();

        bool playerHasSpawned = managerMod.playerHasSpawned; 

        GameObject newPlayerPrefab;

        if (!playerHasSpawned)
        {
            newPlayerPrefab = spawnPrefabs[0];
            managerMod.playerHasSpawned = true;
        }
        else
        {
            newPlayerPrefab = spawnPrefabs[1];
        }

        var player = (GameObject)GameObject.Instantiate(newPlayerPrefab, Vector3.zero, Quaternion.identity);
        NetworkServer.AddPlayerForConnection(conn, player, playerControllerId);
    }
}
