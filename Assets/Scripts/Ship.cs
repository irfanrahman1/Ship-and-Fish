using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

// The Ship class inherits from MonoBehaviour, enabling it to be attached to a Unity GameObject.
public class Ship : MonoBehaviour
{
    // Private field declarations for the Ship class.
    private FishCollector fish; // Reference to the FishCollector component attached to the Camera.main GameObject.
    private GameObject targetFish; // Holds the current target fish GameObject the ship is aiming to collect.
    private Vector3 direction; // Direction vector towards the target fish.
    private Rigidbody2D rb2d; // Rigidbody2D component of the ship for physics-based movement.

    // Start is called before the first frame update
    void Start()
    {
        // Initializes the fish field by getting the FishCollector component from the main camera.
        fish = Camera.main.GetComponent<FishCollector>();
        // Initializes the rb2d field by getting the Rigidbody2D component attached to the same GameObject as this script.
        rb2d = GetComponent<Rigidbody2D>();
    }

    //// Update is called once per frame
    //void Update()
    //{

    //}

    // Coroutine that starts when the GameObject this script is attached to is clicked.
    IEnumerator OnMouseDown()
    {
        // Continues looping as long as there are fish in the fishList of the FishCollector.
        while (fish.fishList.Count != 0)
        {
            // Finds and sets the nearest fish as the target.
            findNearestFish();
            // Waits until the ship's movement has nearly stopped before continuing.
            yield return new WaitUntil(() => rb2d.velocity.magnitude < 0.1f);
        }
    }

    // Called when another GameObject stays within a trigger collider attached to the same GameObject as this script.
    void OnTriggerStay2D(Collider2D other)
    {
        // Checks if the collider belongs to the target fish.
        if (other.gameObject == targetFish)
        {
            // Destroys the target fish GameObject.
            Destroy(targetFish);
            // Removes the target fish from the fishList in the FishCollector.
            fish.fishList.Remove(targetFish);
            // Stops the ship's movement.
            rb2d.velocity = Vector2.zero;
            // Logs the collection of a fish.
            Debug.Log("Fish Collected");
        }
    }

    // Finds the nearest fish from the fishList in the FishCollector and sets it as the target.
    void findNearestFish()
    {
        // Assumes the first fish in the list as the nearest fish initially.
        targetFish = fish.fishList.First();
        // Calculates the distance to this initial fish.
        float nearestDistance = Vector3.Distance(transform.position, targetFish.transform.position);

        // Iterates through all fish in the list to find the actual nearest fish.
        foreach (GameObject fish in fish.fishList)
        {
            float comparingDistance = Vector3.Distance(transform.position, fish.transform.position);
            // If a closer fish is found, updates the nearest fish and distance.
            if (comparingDistance < nearestDistance)
            {
                nearestDistance = comparingDistance;
                targetFish = fish;
            }
        }

        // Sets the direction towards the target fish and applies a force to move the ship in that direction.
        direction = (targetFish.transform.position - transform.position).normalized;
        rb2d.AddForce(direction * 5f, ForceMode2D.Impulse);
    }
}
