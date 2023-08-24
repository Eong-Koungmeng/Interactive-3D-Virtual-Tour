using System.Collections;
using System.Collections.Generic;
using System.Net;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ApplicationControlller : MonoBehaviour
{
    [SerializeField] GameObject cameraControl;
    [SerializeField] GameObject movementControl;
    [SerializeField] GameObject playingUI;
    [SerializeField] GameObject pauseUI;
    private bool pause = false;
    // Start is called before the first frame update
    void Start()
    {
        if(StateTransfer.tourType == "AutomatedTour")
        {
            DisableControl();
        }

        playingUI.SetActive(true);
        pauseUI.SetActive(false);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(!pause)
            {
                PauseScreen();
            }
            else
            {
                Continue();
            }
        }
    }

    public void PauseScreen()
    {
        playingUI.SetActive(false);
        pauseUI.SetActive(true);
        Time.timeScale = 0;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        pause = true;
    }

    public void MainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("StartMenu");
    }

    public void QuitApp()
    {
        Application.Quit();
    }

    public void Continue()
    {
        playingUI.SetActive(true);
        pauseUI.SetActive(false);
        Time.timeScale = 1;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        pause = false;
    }

    private void DisableControl()
    {
        cameraControl.GetComponent<MouseLook>().enabled = false;
        movementControl.GetComponent<PlayerMovement>().enabled = false;
    }

}
