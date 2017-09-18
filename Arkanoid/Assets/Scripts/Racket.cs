using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Racket : MonoBehaviour {

    public float speed = 150;
    private void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        GetComponent<Rigidbody2D>().velocity = Vector2.right * horizontalInput * speed;
    }
}
 