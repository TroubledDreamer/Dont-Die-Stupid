using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BedPressurePlate : MonoBehaviour
{
    private float originalZIndex;
    public float triggeredZIndex = -1f; // Set this to the desired Z index when triggered

    void Start()
    {
        // Save the original Z index
        originalZIndex = transform.position.z;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the player triggers the collider
        if (other.CompareTag("Player"))
        {
            // Change the Z index
            transform.position = new Vector3(transform.position.x, transform.position.y, triggeredZIndex);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        // Check if the player exits the trigger
        if (other.CompareTag("Player"))
        {
            // Revert to the original Z index
            transform.position = new Vector3(transform.position.x, transform.position.y, originalZIndex);
        }
    }
}
