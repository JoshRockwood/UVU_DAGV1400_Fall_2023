using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
     void OnTriggerEnter(Collider other)
    {
        // Destroys the other game object
        Destroy(other.gameObject);
        // Destroys game object
        Destroy(gameObject);
    }
}
