using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowScript : MonoBehaviour
{
    public float speed = 8f;
    public float time = 3f;
    private float lifetimer;
    // Start is called before the first frame update
    void Start()
    {
        lifetimer = time;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;

        lifetimer -= Time.deltaTime;
        if (lifetimer <= 0f)
        {
            Destroy(gameObject);
        }
    }
}
