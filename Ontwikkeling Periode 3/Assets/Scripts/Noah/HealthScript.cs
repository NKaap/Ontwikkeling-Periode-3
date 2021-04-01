using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthScript : MonoBehaviour
{
    public Slider healthSlider;

    public float maxHealth;
    public static float currentHealth;
    public GameObject deathscreen;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        healthSlider.value = currentHealth;

        if (currentHealth <= 0)
        {
            Cursor.lockState = CursorLockMode.None;
            deathscreen.SetActive(true);
        }

    }
}
