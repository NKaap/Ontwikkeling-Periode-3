using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCollectScript : MonoBehaviour
{
    public GameObject portal;
    public bool[] gotKeys;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Key")
        {
            for (int i = 0; i < gotKeys.Length; i++)
            {
                if (gotKeys[i] == false)
                {
                    gotKeys[i] = true;
                    break;
                }
            }
            Destroy(collision.gameObject);


        }
        if (collision.gameObject.tag == "Gate")
        {
            bool gotAllTheKeys = true;
            for (int i = 0; i < gotKeys.Length; i++)
            {
                if (gotKeys[i] == false)
                {
                    gotAllTheKeys = false;
                    break;
                }
            }
            if (gotAllTheKeys == true)
            {
                Destroy(collision.gameObject);
            }
        }
    }

}
