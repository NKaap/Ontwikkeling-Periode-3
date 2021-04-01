using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class keys : MonoBehaviour
{
    public bool[] gotKeys;
    public Text text;
    public int keyCount;


    private void OnCollisionEnter(Collision collision)
    {        
        if (collision.gameObject.tag == "Key")
        {
            for (int i = 0; i < gotKeys.Length; i++)
            {
                if (gotKeys[i] == false)
                {
                    keyCount = i;
                    text.text = i.ToString(); 
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
    

