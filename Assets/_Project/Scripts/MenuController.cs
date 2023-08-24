using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{

    public void LoadTour()
    {
        StateTransfer.tourType = "3DTour";
        SceneManager.LoadScene("MainScene");
    }

    public void LoadAutomated()
    {
        StateTransfer.tourType = "AutomatedTour";
        SceneManager.LoadScene("MainScene");
    }

    public void QuitApp()
    {
        Application.Quit();
    }
}
