using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageMovement : MonoBehaviour
{
    public LayerMask platformLayer; 

    private bool _isOnPlatform;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _isOnPlatform = Physics.Raycast(transform.position, Vector3.down, 0.1f, platformLayer);
        if(_isOnPlatform)
        {
            Debug.Log("onPlatform");
        }
        else
        {
        }
    }
}
