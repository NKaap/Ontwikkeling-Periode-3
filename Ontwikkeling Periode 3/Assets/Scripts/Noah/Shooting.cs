using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public float damage;
    public float range;
    public RaycastHit hit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            if(Physics.Raycast(transform.position, transform.forward, out hit, range))
            {
                if(hit.collider.tag == "Enemy")
                {
                    
                }
            }
        }
    }
}
