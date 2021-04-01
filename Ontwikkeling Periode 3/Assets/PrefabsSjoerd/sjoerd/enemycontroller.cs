﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemycontroller : MonoBehaviour
{
    public float lookRadius = 10f;

    Transform Target;
    NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        Target = PlayerManeger.instance.player.transform;
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(Target.position, transform.position);

        if (distance <= lookRadius)
        {
            agent.SetDestination(Target.position);
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }
}
