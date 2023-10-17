using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    public ScoreManager scoreManager; // Store reference to score manager
    public int scoreToGive;

    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>(); // Find ScoreManager game object and reference ScoreManager script component
    }
     void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player") && !other.CompareTag("Enemy"))
        {
            // Increase the score
            scoreManager.IncreaseScore(scoreToGive);
            // Destroys the other game object
            Destroy(other.gameObject);
        }
        // Destroys game object
        Destroy(gameObject);
    }
}
