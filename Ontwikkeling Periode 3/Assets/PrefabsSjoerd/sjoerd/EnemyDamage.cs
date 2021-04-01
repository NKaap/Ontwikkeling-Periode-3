using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public GameObject Enemy;
    public float range = 1f;
    public float damage = 1f;
    public float fireRate = 15f;

    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(Enemy.transform.position, Enemy.transform.forward, out hit, range))
        {
            PlayerHealth target = hit.transform.GetComponent<PlayerHealth>();
            if (target != null)
            {
                target.TakeDamage(damage);
            }
        }
    }
   
}
