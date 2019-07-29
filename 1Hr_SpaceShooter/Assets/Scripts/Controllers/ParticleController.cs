using UnityEngine;


public class ParticleController : MonoBehaviour
{
    public void OnEnemyDeath(Enemy enemy)
    {
        Instantiate(enemy.deathSprite, enemy.transform.position, enemy.transform.rotation);
        Destroy(enemy.gameObject);
    }

    public void OnPlayerDeath(Player player)
    {
        Instantiate(player.DestroyedSprite, player.transform.position, player.transform.rotation);
    }
}
