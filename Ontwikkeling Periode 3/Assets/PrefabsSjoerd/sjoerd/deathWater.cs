using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class deathWater : MonoBehaviour
{
    void OnCollisionEnter(Collision collisioninfo)
    {
        if (collisioninfo.collider.tag == "Water")
        {
            SceneManager.LoadScene("levelTegenwoordig");
        }
    }
}
