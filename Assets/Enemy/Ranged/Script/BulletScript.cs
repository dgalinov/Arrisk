using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    float moveSpeed = 7f;
    Rigidbody2D rb;
    PlayerPlatformerController player;
    Vector2 moveDirection;
    bool isFacingRight = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindObjectOfType<PlayerPlatformerController>();
        moveDirection = (player.transform.position - transform.position).normalized * moveSpeed;
        if (moveDirection.x > -40.53) {
            transform.Rotate(0,180,0);
        } else if (moveDirection.x < -40.53) {
            transform.Rotate(0,180,0);
        }
        rb.velocity = new Vector2(moveDirection.x, moveDirection.y);
        Destroy(gameObject, 3f);
        
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.name.Equals("Player")) {
            Debug.Log("Hit!");
            Destroy(gameObject);
        }
    }
}
