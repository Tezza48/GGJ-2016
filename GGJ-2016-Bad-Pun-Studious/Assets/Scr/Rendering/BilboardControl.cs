using UnityEngine;
using System.Collections;

public class BilboardControl : MonoBehaviour {

    private static Quaternion bilboardRotation;

    public static Quaternion BilboardRotation
    {
        get
        {
            return bilboardRotation;
        }
    }

    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        bilboardRotation = Quaternion.LookRotation(transform.localPosition, Vector3.up);
	}
}
