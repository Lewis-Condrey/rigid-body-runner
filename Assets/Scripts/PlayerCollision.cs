using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public Rigidbody rb;
    public float upForce = 2000f;
    public float backForce = 2000f;
    public PlayerMovement movement;
    public AudioSource audioSource;
    public float volume = 0.5f;

    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
            rb.AddForce(0, upForce, -backForce * Time.deltaTime);
        }
    }
}