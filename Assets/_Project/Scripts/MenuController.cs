using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    [SerializeField] private GameObject startMenu;
    [SerializeField] private GameObject instruction;
    [SerializeField] private GameObject credit;
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

    public void ShowInstruction()
    {
        startMenu.SetActive(false);
        instruction.SetActive(true);
    }

    public void Back()
    {
        instruction.SetActive(false);
        credit.SetActive(false);
        startMenu.SetActive(true);
    }
    public void ShowCredits()
    {
        startMenu.SetActive(false);
        credit.SetActive(true);
    }
}
