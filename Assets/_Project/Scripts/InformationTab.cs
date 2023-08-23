using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InformationTab : MonoBehaviour
{
    [SerializeField] private GameObject informationUI;
    [TextArea]
    [SerializeField] private string information;
    private Image image;
    private TMP_Text text;

    void Start()
    {
        image = informationUI.GetComponent<Image>();
        text = informationUI.transform.GetChild(0).GetComponent<TMP_Text>();
    }

    private void OnTriggerEnter(Collider other)
    {
        text.text = information;
        informationUI.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        informationUI.SetActive(false);
    }
}
