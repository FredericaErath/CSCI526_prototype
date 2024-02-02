using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    // Start is called before the first frame update
    private BoxCollider2D _boxCollider2D;
    public float transparency = 0.5f;
    void Start()
    {
        Renderer renderer = GetComponent<Renderer>();
        Material rendererMaterial = renderer.material;
        _boxCollider2D = GetComponent<BoxCollider2D>();
        StartCoroutine(PlatformRoutine(_boxCollider2D, rendererMaterial));
    }

    private IEnumerator PlatformRoutine(BoxCollider2D boxCollider2D, Material material)
    {
        float appearInterval = 1f; // the beat
        while (true)
        {
            yield return new WaitForSeconds(appearInterval); // wait
            
             // ban the platform
            boxCollider2D.enabled = !boxCollider2D.enabled;
            Color color = material.color;
            if (boxCollider2D.enabled == false)
            {
                color.a = transparency;
                material.color = color;
            }
            else
            {
                color.a = 1;
                material.color = color;
            }

            
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
