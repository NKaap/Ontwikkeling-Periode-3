using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderScript : MonoBehaviour
{
    public float range = 10f;
    public GameObject canvas;
    public RaycastHit hit;
    // Start is called before the first frame update
    void Start()
    {

    }
    public void BorderDetect()
    {
        if (Physics.Raycast(transform.position, transform.forward,out hit, range))
        {
            if (hit.transform.gameObject.tag == "WorldBorder")
            {
                canvas.SetActive(true);
            }
        }
        
    }
    
}
