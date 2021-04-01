using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalManagment : MonoBehaviour
{
    public bool levelVerleden, levelHeden, levelToekomt;
    public string portal1, portal2, portal3;
    public GameObject gate1, gate2, gate3;
    public GameObject trigger1, trigger2, trigger3;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == portal1)
        {
            
            levelVerleden = true;
            gate2.SetActive(true);
            trigger1.SetActive(false);
        }
        if (collision.collider.tag == portal3)
        {
            levelHeden = true;
            gate3.SetActive(true);
            trigger2.SetActive(false);
        }
        if (collision.collider.tag == portal3)
        {
            if(trigger3.activeInHierarchy == true)
            {
                SceneManager.LoadScene("Level Toekomst");
            }
            levelToekomt = true;
            trigger3.SetActive(false);
        }
    }

}
