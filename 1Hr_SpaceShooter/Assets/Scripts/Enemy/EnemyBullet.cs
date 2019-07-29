using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    void Update()
    {
        transform.Translate(Time.deltaTime * 8 * Vector3.down);
    }
}
