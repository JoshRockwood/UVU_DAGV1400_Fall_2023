using UnityEngine;

public class HealthPowerUp : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            // Apply the health value to the player
            ApplyHealth(other.gameObject);
            // Destroy the power-up game object
            Destroy(gameObject);
        }
    }

    private void ApplyHealth(GameObject player)
    {
        // Retrieve player's health component (ex. HealthController script)
        HealthController healthController = player.GetComponent<HealthController>();

        // Check if the player has a health component
        if (healthController != null)
        {
            // Add the health value to the player's current health
            healthController.AddHealth();
        }
    }
}
