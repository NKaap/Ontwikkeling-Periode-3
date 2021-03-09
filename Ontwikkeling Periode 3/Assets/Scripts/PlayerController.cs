using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Movement
    public float v, h;
    public float movementSpeed = 10.0f;

    //Mouse Look
    public float rotateSpeed;
    public Transform cam;


    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        v = Input.GetAxis("Vertical");
        h = Input.GetAxis("Horizontal");

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
    }
}
