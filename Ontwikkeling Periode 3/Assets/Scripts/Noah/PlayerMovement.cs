﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    //Movement
    public float movementSpeed = 10.0f;

    //Mouse Look
    public float rotateSpeed;
    public Transform cam;

    //Jump
    public Vector3 jump;
    public float jumpForce = 2.0f;

    public bool isGrounded;
    Rigidbody rb;

    //portal
    public GameObject gate3;
    public string portal3;
    public bool activePortal;
    public GameObject trigger3;

    //KillCOunt
    public int killCount;
    public Text text;
    public RaycastHit hit;
    public string taggName;
    public GameObject canvasGo;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;

        //Jump
        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 2.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        //Movement
        float v = Input.GetAxis("Vertical");
        float h = Input.GetAxis("Horizontal");

        Vector3 move = new Vector3();
        move.x = h;
        move.z = v;

        GetComponent<Transform>().Translate(move * Time.deltaTime * movementSpeed);

        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        Vector3 rotateVector = new Vector3();
        rotateVector.y = mouseX;

        Vector3 rotateCam = new Vector3();
        rotateCam.x -= mouseY;

        transform.Rotate(rotateVector * rotateSpeed * Time.deltaTime);

        cam.Rotate(rotateCam * rotateSpeed * Time.deltaTime);

        //Jumping
        if ((Input.GetButtonDown("Jump") && isGrounded))
        {

            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }

        //Killcount
        text.text = killCount.ToString();

        if(killCount >= 199)
        {
            gate3.SetActive(true);
            canvasGo.SetActive(true);
        }
        if (Input.GetKeyDown("b"))
        {
            killCount = 200;
        }
        if (Physics.Raycast(transform.position, transform.forward, out hit, 1000))
        {
            if (Input.GetButton("Fire1"))
            {
                if(hit.transform.tag == "Enemy")
                {
                    killCount += 1;
                }
            }
        }
        
    }
    void OnCollisionStay()
    {
        isGrounded = true;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Portal3")
        {
            if (trigger3.activeInHierarchy == true)
            {
                SceneManager.LoadScene("Lobby");
            }
        }
    }

}
