using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class sceneLoader : MonoBehaviour
{
    public GameObject canvasPause;
    public GameObject canvasGame;
    public GameObject canvasEnd;
    public void PlayAgain()
    {
        SceneManager.LoadScene("levelTegenWoordig");
        Time.timeScale = 1;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
    public void QuitGame()
    {

        Application.Quit();

    }
    public void ResumeGame()
    {
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.Locked;
        canvasPause.SetActive(false);
        canvasGame.SetActive(true);
        Cursor.visible = false;
    }
    public void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            Time.timeScale = 0;
            Cursor.lockState = CursorLockMode.None;
            canvasPause.SetActive(true);
            canvasGame.SetActive(false);
            Cursor.visible = true;
        }
    }
    public void Lobby()
    {
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        SceneManager.LoadScene("Lobby");
    }
}
