using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyKill : MonoBehaviour
{
    private Vector3 initialPosition;
    public float moveSpeed = 2f; // Adjust the speed as needed
    public float moveDistance = 1f; // Adjust the distance of the movement as needed
    private bool movingUp = true;
    
    // Start is called before the first frame update
    void Start()
    {
        // Store the initial position of the enemy
        initialPosition = transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move the enemy up and down
        MoveUpDown();
    }

    private void MoveUpDown()
    {
        // Calculate the new position based on the movement
        float newY = movingUp ? initialPosition.y + moveDistance : initialPosition.y - moveDistance;
        Vector3 newPosition = new Vector3(initialPosition.x, newY, initialPosition.z);

        // Move the enemy towards the new position
        transform.position = Vector3.MoveTowards(transform.position, newPosition, moveSpeed * Time.deltaTime);

        // If the enemy reaches the new position, change the direction
        if (Vector3.Distance(transform.position, newPosition) < 0.1f)
        {
            movingUp = !movingUp;
        }
    }
    
    
}


