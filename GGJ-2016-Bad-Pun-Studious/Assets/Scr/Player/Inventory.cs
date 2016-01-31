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
    
    public List<bool> inventoryValues;

	// Use this for initialization
	void Start ()
    {
        for (int i = 0; i < inventoryNames.Length; i++)
        {
            inventoryValues.Add(false);
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerStay2D(Collider2D other)
    {
        if (Input.GetButtonDown("Use") && other.tag == "Item")
        {
            print("Triggered!");
            for (int i = 0; i < inventoryNames.Length; i++)
            {
                if (inventoryNames[i].ToLower().Equals(other.name.ToLower()))
                {
                    inventoryValues[i] = true;
                    other.GetComponent<NetworkDestroyable>().destroy = true;
                    Debug.Log("Destroying " + other.name + ".");
                    break;
                }
            }
        }
    }
}
