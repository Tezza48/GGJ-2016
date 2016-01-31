using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

[RequireComponent(typeof(Rigidbody2D))]
public class HostPlayer : NetworkBehaviour  {

    public float speed = 5;
    private Rigidbody2D rigid;

	// Use this for initialization
	void Start () {
        rigid = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        if (isLocalPlayer)
        {
            float inputX = Input.GetAxisRaw("Horizontal");
            float inputY = Input.GetAxisRaw("Vertical");

            Vector2 moveDir = inputX * Vector2.right + inputY * Vector2.up;

            rigid.velocity = moveDir.normalized * speed;
        }

    }
}
