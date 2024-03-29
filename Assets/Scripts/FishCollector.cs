using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishCollector : MonoBehaviour
{

    [SerializeReference] GameObject fishPrefab;
    public List<GameObject> fishList = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Checks if the right mouse button (button index 1) was clicked.
        if (Input.GetMouseButtonDown(1))
        {
            // Calculates the world position from the mouse's position on the screen.
            Vector3 mousePosition = Input.mousePosition; // Gets the screen position of the mouse.
            mousePosition.z = -Camera.main.transform.position.z; // Adjusts for camera's z position to ensure proper world position calculation.
            Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePosition); // Converts the screen position to a world position.

            // Instantiates a new fish GameObject using the fishPrefab.
            GameObject fish = Instantiate<GameObject>(fishPrefab);
            fish.transform.position = worldPosition; // Sets the instantiated fish's position to the calculated world position.

            fishList.Add(fish); // Adds the newly instantiated fish to the fishList for tracking.
        }
    }
}
