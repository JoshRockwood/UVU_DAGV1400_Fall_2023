using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PowerUpAction : MonoBehaviour
{
    public UnityEvent onCollisionEvent;
    public int value; // Value of the pickup
    public float lowBound;

    // Trigger event
    void OnCollisionEnter(Collision collision)
    {
        // Check if collide with player
        if (collision.gameObject.CompareTag("Player"))
        {
            onCollisionEvent.Invoke();

            PlayerController player = collision.gameObject.GetComponent<PlayerController>(); // Access player controller script

            if (player != null)
            {
                player.CollectItem(value); // Collect the powerup
                Destroy(gameObject); // Destroys powerup upon contact with player
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
