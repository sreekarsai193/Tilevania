using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    [SerializeField] AudioClip coinPickupSFX;

    [SerializeField]int pointsForCoinPickup = 100;
    
    bool wasCollected=false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if(collision.tag=="Player" && !wasCollected)
        {
            wasCollected = true;
            FindObjectOfType<GameSession>().AddToScore(pointsForCoinPickup);
            Destroy(gameObject);
            AudioSource.PlayClipAtPoint(coinPickupSFX, new 
                Vector3(transform.position.x,transform.position.y,
                Camera.main.transform.position.z));
        }
    }
}
