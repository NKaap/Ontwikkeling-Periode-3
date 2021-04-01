using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WinScreenTrigger : MonoBehaviour
{
    public GameObject winScreen;
    private void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            Cursor.lockState = CursorLockMode.None;
            winScreen.SetActive(true);
        }
    }
    public void RestartLevel()
    {
        SceneManager.LoadScene ("levelVerledenJos");
    }
    
    public void LoadMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }


}
