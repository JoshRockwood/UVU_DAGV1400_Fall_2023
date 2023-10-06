using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SpawnPowerUp : MonoBehaviour
{
    public GameObject powerUp;
    public Transform spawner;
    public UnityEvent onCollisionEvent;
    public int value = 1; // Value of the pickup

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CreatePowerUp());
    }

    // Set up a spawn time
    IEnumerator CreatePowerUp()
    {
        yield return new WaitForSeconds(5); // Define how many sec. to wait
        Instantiate(powerUp, spawner.transform.position, powerUp.transform.rotation); // Spawn in powerUp
    }

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