using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    }
    void OnCollisionStay()
    {
        isGrounded = true;
    }
}
