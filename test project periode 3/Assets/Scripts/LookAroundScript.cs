using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAroundScript : MonoBehaviour
{
    public float maxMouseUp;
    public float maxMouseDown;
    public Transform cam;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");
        Vector3 Rot = new Vector3();
        Rot.y = mouseX;
        transform.Rotate(Rot);
        Vector3 camRotate = new Vector3();
        camRotate.x = -mouseY;
        cam.Rotate(camRotate);


        //clamping

        Vector3 curRotation = cam.eulerAngles;
        if(curRotation.x > 180)
        {
            curRotation.x -= 360;
        }

        curRotation.x = Mathf.Clamp(curRotation.x, maxMouseDown, maxMouseUp);

        cam.eulerAngles = curRotation;
    }

}
