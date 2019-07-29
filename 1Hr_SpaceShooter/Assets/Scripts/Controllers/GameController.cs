using System.Diagnostics.CodeAnalysis;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private ScoreController _scoreController;
    private UIController _uiController;
    private ParticleController _particleController;


    private void Awake()
    {
        _scoreController = FindObjectOfType<ScoreController>();
        _uiController = FindObjectOfType<UIController>();
        _particleController = FindObjectOfType<ParticleController>();
        
        Enemy.OnEnemyDeath += OnEnemyDeath;
        Player.PlayerDeath += OnPlayerDeath;
    }

    private void OnEnemyDeath(Enemy enemy)
    {
        _scoreController.AddScore(enemy.value);
        _particleController.OnEnemyDeath(enemy);
    }
    
    private void OnPlayerDeath(Player player)
    {
        _particleController.OnPlayerDeath(player);
        _uiController.DisplayScore(_scoreController.Score);
    }
    
    private void OnDisable()
    {
        Enemy.OnEnemyDeath -= OnEnemyDeath;
        Player.PlayerDeath -= OnPlayerDeath;
    }
}