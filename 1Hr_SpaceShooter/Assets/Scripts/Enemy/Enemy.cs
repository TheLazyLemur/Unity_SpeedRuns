using System;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public static event Action<Enemy> OnEnemyDeath = delegate {  }; 
    
    public int value;
    public float moveSpeed;
    private Rigidbody2D _rb;

    public float Accel;
    public GameObject deathSprite;

    private void Update()
    {
        var acceleration = new Vector3(0, Accel, 0);
        var velocity = new Vector3();
        
        velocity +=  acceleration;
        transform.position += Time.deltaTime * moveSpeed * velocity;
    }
    
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            Destroy(other.gameObject);
            OnEnemyDeath(this);
        }
    }
}
