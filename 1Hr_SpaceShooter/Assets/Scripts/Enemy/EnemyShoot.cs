using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public GameObject enemyProj;
    private float fireDelay = 0.8f;
    private float _currentDelay;
    private readonly List<GameObject> _projectiles = new List<GameObject>();

    private void Awake()
    {
        _currentDelay = 1;
    }

    private void Update()
    {
        _currentDelay -= Time.deltaTime;
    
        if (!(_currentDelay <= 0)) return;
        
        var proj = Instantiate(enemyProj, transform.position, transform.rotation);
        _projectiles.Add(proj);
        _currentDelay = fireDelay;
    }

    private void DestroyAllProjectiles()
    {
        foreach (var proj in _projectiles)
        {
            Destroy(proj);
        }
    }

    private void OnDisable()
    {
        DestroyAllProjectiles();
    }
}