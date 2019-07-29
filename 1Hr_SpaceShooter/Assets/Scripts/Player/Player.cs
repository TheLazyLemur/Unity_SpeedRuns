using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 10;
    public GameObject DestroyedSprite;
    
    private bool _dead;
    private PlayerShoot _weapon;
    
    public static Action<Player> PlayerDeath = delegate {  };
    
    private void Awake()
    {
        _weapon = GetComponent<PlayerShoot>();
    }

    private void Update()
    {
        if (!_dead)
        {
            Movement();
            _weapon.Shoot();
        }
    }

    private void Movement()
    {
        var horMov = Input.GetAxisRaw("Horizontal");
        var verMov = Input.GetAxisRaw("Vertical");

        var acceleration = new Vector3(horMov, verMov, 0);
        var velocity = new Vector3();

        velocity += acceleration;
        transform.position += Time.deltaTime * speed * velocity;

        ClampMovement();
    }

    private void ClampMovement()
    {
        if (transform.position.y >= 4)
        {
            transform.position = new Vector3(transform.position.x, 4, transform.position.z);
        }


        if (transform.position.y <= -4)
        {
            transform.position = new Vector3(transform.position.x, -4, transform.position.z);
        }


        if (transform.position.x >= 6)
        {
            transform.position = new Vector3(6, transform.position.y, transform.position.z);
        }


        if (transform.position.x <= -6)
        {
            transform.position = new Vector3(-6, transform.position.y, transform.position.z);
        }
    }


    private void OnCollisionEnter2D(Collision2D other)
    {
        if (_dead) return;
        if (!other.gameObject.CompareTag("Enemy")) return;
        
        _dead = true;
        PlayerDeath(this);
        Invoke(nameof(Kill), 5);
    }

    private void Kill()
    {
        Destroy(gameObject);
    }
}