using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PowerUpAction : MonoBehaviour
{
    // public UnityEvent onCollisionEvent;
    public int value; // Value of the pickup
    public float lowBound;
    private ScoreManager scoreManager;

    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

    // Trigger event
    void OnTriggerEnter(Collider collision)
    {
        // Check if collide with player
        if (collision.gameObject.CompareTag("Player"))
        {
            // onCollisionEvent.Invoke();

            PlayerController player = collision.gameObject.GetComponent<PlayerController>(); // Access player controller script

            if (player != null)
            {
                Destroy(gameObject); // Destroys powerup upon contact with player
                scoreManager.IncreaseScore(value);
            }
        }
    }

    void Update()
    {
        if (transform.position.z < lowBound)
        {
            Destroy(gameObject);
        }
    }
}
