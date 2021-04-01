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
    public Text ammoText;
    public int health = 100;
    public Text healText;

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
                ammoText.text = "Ammo: " + ammo;
                healText.text = "Health: " + health;

                GameObject bulletObject = Instantiate(arrowPrefab);
                bulletObject.transform.position = cam.transform.position + cam.transform.forward;
                bulletObject.transform.forward = cam.transform.forward;
            }
        }
       

    }


}
