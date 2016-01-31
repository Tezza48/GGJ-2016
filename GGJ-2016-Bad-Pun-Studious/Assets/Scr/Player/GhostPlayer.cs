using UnityEngine;
using System.Collections;

public class GhostPlayer : MonoBehaviour {

    private float speed = 10;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        float inputX = Input.GetAxisRaw("Horizontal");
        float inputY = Input.GetAxisRaw("Vertical");

        Vector2 moveDir = new Vector2(inputX, inputY) * speed * Time.deltaTime;

        transform.position += (Vector3)moveDir;
    }
}
