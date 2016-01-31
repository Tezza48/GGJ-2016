using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class ManagerMod : NetworkBehaviour
{
    [SyncVar]
    public bool playerHasSpawned;
}