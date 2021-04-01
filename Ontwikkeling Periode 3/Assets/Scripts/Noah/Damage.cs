using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public float damage;
    public string taggName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == taggName)
        {
            TakeDamage();
        }
    }
    public void TakeDamage()
    {
        HealthScript.currentHealth -= damage;
    }
}
