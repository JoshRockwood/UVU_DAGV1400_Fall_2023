using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed;
    public float xRange;
    public Transform blaster;
    public GameObject laserBolt;
    private int inventory; // Player's inventory
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        //Set horizontalInput to receive values from keyboard
        horizontalInput = Input.GetAxis("Horizontal");

        // Moves Player left and right
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        // Keep Player within bounds
        //Left side wall
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        //Right side wall
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        // Gets space input from keyboard and assigns it to create laser
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Creates laser at blaster position and maintains laser rotation
            Instantiate(laserBolt, blaster.transform.position, laserBolt.transform.rotation);   
        }
    }

    // Destroy gameObject that touches Player
    private void OnTriggerEvent(Collider other)
    {
        Destroy(other.gameObject);
    }

    public void CollectItem(int value)
    {
        inventory += value;
        Debug.Log("You have a " + inventory);
    }
}
