using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 2.0f; // Adjust this value to set the movement speed
    public float amplitude = 1.0f; // Adjust this value to set the movement amplitude

    private float originalY;
    // Start is called before the first frame update
    void Start()
    {
        originalY = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        float verticalMovement = amplitude * Mathf.Sin(Time.time * speed);

        // Set the new position of the GameObject
        transform.position = new Vector3(transform.position.x, originalY + verticalMovement, transform.position.z);
    }
}
