using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBound;
    public float lowBound;
    void Awake()
    {
        // Reset time scale
        //Time.timeScale = 1;
    }
    // Update is called once per frame
    void Update()
    {
        // Destroys object if it passes topBound
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowBound)
        {
            Debug.Log ("Game Over!");
            Destroy(gameObject);
            //Time.timeScale = 0;
        }
    }
}
