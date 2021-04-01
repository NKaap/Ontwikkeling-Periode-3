using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portals : MonoBehaviour
{
    public GameObject canvasEnd;
    public GameObject canvasGame;
    void OnCollisionEnter(Collision collisioninfo)
    {
        if (collisioninfo.collider.tag == "portal")
        {
            canvasEnd.SetActive(true);
            canvasGame.SetActive(false);
            Cursor.visible = true;
        }
    }
}
