using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    [SerializeField] private GameObject startMenu;
    [SerializeField] private GameObject instruction;
    [SerializeField] private GameObject credit;
    [SerializeField] private GameObject settings;
    [SerializeField] private GameObject virtualTourOption;
    [SerializeField] private GameObject _AvirtualTourOption;

    public void LoadTour()
    {
        startMenu.SetActive(false);
        virtualTourOption.SetActive(true);
    }

    public void LoadIDT()
    {
        StateTransfer.tourType = "3DTour";
        StateTransfer.buildingName = "IDT";
        SceneManager.LoadScene("MainScene");
    }

    public void LoadSTEM()
    {
        StateTransfer.tourType = "3DTour";
        StateTransfer.buildingName = "STEM";
        SceneManager.LoadScene("MainScene STEM");
    }

    public void LoadAutomated()
    {
        startMenu.SetActive(false);
        _AvirtualTourOption.SetActive(true);
    }

    public void LoadAutomatedIDT()
    {
        StateTransfer.tourType = "AutomatedTour";
        StateTransfer.buildingName = "IDT";
        SceneManager.LoadScene("MainScene");
    }

    public void LoadAutomatedSTEM()
    {
        StateTransfer.tourType = "AutomatedTour";
        StateTransfer.buildingName = "STEM";
        SceneManager.LoadScene("MainScene STEM");
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
        settings.SetActive(false);
        virtualTourOption.SetActive(false);
        _AvirtualTourOption.SetActive(false);
    }
    public void ShowCredits()
    {
        startMenu.SetActive(false);
        credit.SetActive(true);
    }

    public void ShowSettings()
    {
        startMenu.SetActive(false);
        settings.SetActive(true);
    }
}
