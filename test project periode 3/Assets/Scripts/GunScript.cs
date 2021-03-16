using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{
    public float damage = 10;
    public float range = 100f;
    public ParticleSystem muzzleFlash;
    
   
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }
    void Shoot()
    {
        muzzleFlash.Play();
        RaycastHit hit; //hier maakt die de raycast aan.
        if (Physics.Raycast(transform.position, transform.forward, out hit, range))
        {
            if (hit.collider.tag == "Enemy")
            {
                hit.transform.GetComponent<TargetScript>().TakeDamage(damage);
            }
        }
    }
}

