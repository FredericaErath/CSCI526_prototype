using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(PlatformRoutine());
    }

    private IEnumerator PlatformRoutine()
    {
        WaitForSeconds waitAppear = new WaitForSeconds(1f); // 平台出现的等待时间
        WaitForSeconds waitDisappear = new WaitForSeconds(1f); // 平台消失的等待时间

        while (true)
        {
            yield return waitAppear; // 等待平台出现的时间

            // activate the platform
            gameObject.SetActive(true);

            yield return waitDisappear; // 等待平台消失的时间

            // ban the platform
            gameObject.SetActive(false);
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
