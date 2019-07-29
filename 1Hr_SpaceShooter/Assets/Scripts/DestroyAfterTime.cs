using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterTime : MonoBehaviour
{
    private float _time = 0.5f;

    // Update is called once per frame
    void Update()
    {
        _time -= Time.deltaTime;
        
        if(_time <= 0)
            Destroy(gameObject);
    }
}
