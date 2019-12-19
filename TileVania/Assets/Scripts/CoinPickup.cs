using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    [SerializeField] AudioClip coinPickupSFX;
    [SerializeField] int pointsPerCoin = 100;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        FindObjectOfType<GameSession>().AddToScore(pointsPerCoin);
        AudioSource.PlayClipAtPoint(coinPickupSFX, Camera.main.transform.position);
        Destroy(gameObject);
    }
}
