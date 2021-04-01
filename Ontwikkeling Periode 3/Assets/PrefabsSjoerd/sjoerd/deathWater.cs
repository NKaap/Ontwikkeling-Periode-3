using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class deathWater : MonoBehaviour
{
    public GameObject canvasDeath;
    public GameObject canvasGame;
    void OnCollisionEnter(Collision collisioninfo)
    {
        if (collisioninfo.collider.tag == "Water")
        {
            canvasDeath.SetActive(true);
            canvasGame.SetActive(false);
            Time.timeScale = 0;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}
