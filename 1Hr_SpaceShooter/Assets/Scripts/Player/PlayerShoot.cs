using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject obj;
    public float fireDelay;
    private float delay;

    private void Awake()
    {
        delay = fireDelay;
    }

    public void Shoot()
    {
        delay -= Time.deltaTime;

        if (Input.GetKey(KeyCode.Space) && delay <= 0)
        {
            Instantiate(obj, transform.position, transform.rotation);
            delay = fireDelay;
        }
    }
}