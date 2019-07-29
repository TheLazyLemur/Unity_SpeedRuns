using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnEnemies : MonoBehaviour
{
    public List<Transform> spawnPoints = new List<Transform>();
    public List<GameObject> enemies = new List<GameObject>();

    public float SpawnTime;
    private float currentTime;


    private void Awake()
    {
        currentTime = SpawnTime;
    }

    private void Update()
    {
        currentTime -= Time.deltaTime;

        if (currentTime <= 0)
        {
            currentTime = SpawnTime;
            SpawnEnemy();
        }
    }

    public void SpawnEnemy()
    {
        foreach (var point in spawnPoints)
        {
            var enemyToSpawn = Random.Range(0, enemies.Count);
            var enemy=  Instantiate(enemies[enemyToSpawn], point);
            enemy.transform.SetParent(null);
        }
    }
}