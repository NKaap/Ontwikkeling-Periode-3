using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Restart()
    {
        SceneManager.LoadScene("Level Toekomst");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
    public void Lobby()
    {
        SceneManager.LoadScene("Lobby");
    }
    public void Quit()
    {
        Application.Quit();
    }
}
