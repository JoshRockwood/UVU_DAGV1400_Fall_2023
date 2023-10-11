using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SpawnPowerUp : MonoBehaviour
{
    public GameObject powerUp;
    public Transform spawner;

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
}