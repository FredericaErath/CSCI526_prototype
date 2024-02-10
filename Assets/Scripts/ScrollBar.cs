using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollBar : MonoBehaviour
{
    // Start is called before the first frame update
    public Scrollbar scrollbar;
    public float speed = 1f;

    void Start()
    {
        scrollbar = GetComponent<Scrollbar>();
    }

    // Update is called once per frame
    void Update()
    {
        // Calculate the new value for the scrollbar based on time
        float newValue = Mathf.PingPong(Time.time * speed, 1f);
        
        // Set the scrollbar's value to the new value
        scrollbar.value = newValue;
       
    }
}
