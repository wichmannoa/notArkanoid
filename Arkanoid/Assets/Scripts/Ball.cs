using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    public float speed = 200.0f;
    private int destroyedBricks;

    public int DestroyedBricks
    {
        get {
            return destroyedBricks;
        }
    }
    void Start () {
        GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;
        destroyedBricks = 0;
    }
    public int GetDestroyedBricks() {
        return this.destroyedBricks;
    }
    float HitFactor(Vector2 ballPos, Vector2 racketPos, float racketWidth) {
        return (ballPos.x - racketPos.x) / racketWidth;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "racket")
        {
            float relativePOS = HitFactor(transform.position, collision.transform.position, collision.collider.bounds.size.x);

            Vector2 dir = new Vector2(relativePOS, 1).normalized;

            GetComponent<Rigidbody2D>().velocity = dir * speed;
        }
        else if (collision.gameObject.CompareTag("brick")) {
            destroyedBricks += 1;
        }
    }
 


}
