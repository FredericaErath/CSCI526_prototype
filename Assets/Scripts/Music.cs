using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticMusic : MonoBehaviour
{
    // Start is called before the first frame update
    private Canvas canvas;
    private RectTransform rectTransform;
    void Start()
    {
        // Get the Canvas component
        canvas = GetComponent<Canvas>();
        if (canvas == null)
        {
            Debug.LogError("Canvas component not found.");
            return;
        }

        // Get the RectTransform component of the UI element
        rectTransform = GetComponentInChildren<RectTransform>();
        if (rectTransform == null)
        {
            Debug.LogError("RectTransform component not found.");
            return;
        }

    }

    // Update is called once per frame
    void Update()
    {
        // Ensure the UI element stays in the same position on the screen
        Vector3 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
        screenPosition.x -= 17670;
        screenPosition.y -= 7810;
        Debug.Log(screenPosition);
        rectTransform.position = screenPosition;
    }
}