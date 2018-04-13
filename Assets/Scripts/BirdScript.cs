using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour {

    public float jumpForce = 200f;
    private Rigidbody2D rb;

	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	void Update () {
        if (GameControler.instance.gameover == false)
        {
            if (Input.GetButtonDown("Jump")) {
            rb.velocity = Vector2.zero;
            rb.AddForce(Vector2.up * jumpForce);
            }       
        }
	}
    private void OnTriggerEnter2D(Collider2D collision){
        GameControler.instance.score++;
        Debug.Log(GameControler.instance.score);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameControler.instance.gameover = true;
    }

}
