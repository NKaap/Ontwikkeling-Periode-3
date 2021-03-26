using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    public float vertical;
    public float horizontal;
    public Vector3 move;
    public float speed;
    public GameObject arrowPrefab;
    public GameObject cam;
    
    // Update is called once per frame
    void Update()
    {
        vertical = Input.GetAxis("Vertical");
        horizontal = Input.GetAxis("Horizontal");

        move.x = horizontal;
        move.z = vertical;

        GetComponent<Transform>().Translate(move * Time.deltaTime * speed);
        
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject bulletObject = Instantiate(arrowPrefab);
            bulletObject.transform.position = cam.transform.position + cam.transform.forward;
            bulletObject.transform.forward = cam.transform.forward;
        }
       

    }


}
