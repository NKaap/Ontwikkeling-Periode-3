using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontrollersjoerd : MonoBehaviour
{
    public float moveSpeed;
    public float rotateSpeed;
    public float rotateSpeed1;
    public Transform cam;
    

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 move = new Vector3();

        move.x = h;
        move.z = v;

        transform.Translate(move * moveSpeed * Time.deltaTime);


        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        Vector3 rotateBody = new Vector3();
        rotateBody.y = mouseX;

        Vector3 rotateCam = new Vector3();
        rotateCam.x = mouseY;

        transform.Rotate(rotateBody * rotateSpeed * Time.deltaTime);

        cam.Rotate(rotateCam * rotateSpeed1 * Time.deltaTime);
    }
}