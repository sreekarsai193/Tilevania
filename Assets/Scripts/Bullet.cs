using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float bulletSpeed;
    Rigidbody2D rb2D;
    PlayerMovement player;
    float xspeed;
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        player=FindObjectOfType<PlayerMovement>();
        xspeed=player.transform.localScale.x*bulletSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        rb2D.velocity = new Vector2(xspeed, 0f);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.tag=="Enemy")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject) ;
    }
}
