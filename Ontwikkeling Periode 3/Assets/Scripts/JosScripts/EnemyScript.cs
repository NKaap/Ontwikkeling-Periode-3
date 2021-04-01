using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyScript : MonoBehaviour
{
    public GameObject player;
    public NavMeshAgent raptor;
    public int enemyHealth = 3;
 

    // Update is called once per frame
    void Update()
    {
        raptor.SetDestination(player.transform.position);
        transform.LookAt(player.transform);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Arrow")
        {
            enemyHealth--;
        }
    }

  }
