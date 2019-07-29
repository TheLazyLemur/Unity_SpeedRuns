using System;
using UnityEngine;

public class OutOfBounds : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        Destroy(other.gameObject);
    }

    private void OnCollisionStay(Collision other)
    {
        Debug.Log(other);
        Destroy(other.gameObject);
    }
}