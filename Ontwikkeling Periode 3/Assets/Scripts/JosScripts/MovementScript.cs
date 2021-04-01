using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovementScript : MonoBehaviour
{
    public float vertical;
    public float horizontal;
    public Vector3 move;
    public float speed;
    public GameObject arrowPrefab;
    public GameObject cam;
    public int ammo;
<<<<<<< HEAD
=======
    public Text ammoText;
    public int health = 100;
    public Text healText;
>>>>>>> 0c211ff0fff0aa78c29c315bdacf46851bba5c8c

    void Start()
    {
        ammo = 20;
    }

    // Update is called once per frame
    void Update()
    {
        vertical = Input.GetAxis("Vertical");
        horizontal = Input.GetAxis("Horizontal");

        move.x = horizontal;
        move.z = vertical;

        GetComponent<Transform>().Translate(move * Time.deltaTime * speed);
        
        //shooting script
        
        if (Input.GetButtonDown("Fire1"))
        {
            if (ammo > 0)
            {
                ammo--;
<<<<<<< HEAD
=======
                ammoText.text = "Ammo: " + ammo;
                healText.text = "Health: " + health;
>>>>>>> 0c211ff0fff0aa78c29c315bdacf46851bba5c8c

                GameObject bulletObject = Instantiate(arrowPrefab);
                bulletObject.transform.position = cam.transform.position + cam.transform.forward;
                bulletObject.transform.forward = cam.transform.forward;
            }
        }
       

    }


}
