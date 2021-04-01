using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
<<<<<<< HEAD
=======
    public float damage;
    public float range;
    public RaycastHit hit;
>>>>>>> 0c211ff0fff0aa78c29c315bdacf46851bba5c8c
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD
        
=======
        if (Input.GetButton("Fire1"))
        {
            if(Physics.Raycast(transform.position, transform.forward, out hit, range))
            {
                if(hit.collider.tag == "Enemy")
                {
                    
                }
            }
        }
>>>>>>> 0c211ff0fff0aa78c29c315bdacf46851bba5c8c
    }
}
