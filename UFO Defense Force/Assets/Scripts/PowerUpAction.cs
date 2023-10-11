using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PowerUpAction : MonoBehaviour
{
    public UnityEvent onCollisionEvent;
    public int value = 1; // Value of the pickup

    // Trigger event
    private void OnTriggerEnter(Collider other)
    {
        // Check if collide with player
        if (other.CompareTag("Player"))
        {
            onCollisionEvent.Invoke();

            PlayerController player = other.GetComponent<PlayerController>(); // Access player controller script

            if (player != null)
            {
                 player.CollectItem(value); // Collect the powerup
                 Destroy (gameObject); // Destroys powerup upon contact with player
            }
        }
    }
}
