using UnityEngine;
using UnityEngine.Networking;
using System.Collections;
using System.Collections.Generic;

public class Inventory : NetworkBehaviour {

    private string[] inventoryNames = new string[]
    {
        "cup",
        "kettle",
        "milk",
        "spoon",
        "sugar",
        "teabag",
        "teapot"
    };


    public SyncListBool inventoryValues;

	// Use this for initialization
	void Start ()
    {

    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerStay2D(Collider2D other)
    {
        if (Input.GetButtonUp("Use") && other.CompareTag("Item"))
        {
            for (int i = 0; i < inventoryNames.Length; i++)
            {
                if (inventoryNames[i].Equals(other.name))
                {
                    inventoryValues[i] = true;
                    Network.Destroy(other.gameObject);
                    break;
                }
            }
        }
    }
}
