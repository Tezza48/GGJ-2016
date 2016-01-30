using UnityEngine;
using System.Collections;

public class BilboardControl : MonoBehaviour {

    private static Vector3 targetLook;
    private static Vector3 targetUp;

    public static Vector3 TargetLook
    {
        get
        {
            return targetLook;
        }
    }

    public static Vector3 TargetUp
    {
        get
        {
            return targetUp;
        }

        set
        {
            targetUp = value;
        }
    }

    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        targetLook = transform.localPosition;
        targetUp = transform.up;
	}
}
