using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour
{
    [SerializeField] private Slider slider;
    [SerializeField] private TextMeshProUGUI sliderText;
    [SerializeField] bool sensitivity;
    // Start is called before the first frame update
    void Start()
    {
        slider.onValueChanged.AddListener((v) =>
        {
            sliderText.text = slider.value.ToString();
        });

        if (sensitivity)
        {
            slider.onValueChanged.AddListener((v) =>
            {
                StateTransfer.sentitvity = (int)v;
            });
        }
        else
        {
            slider.onValueChanged.AddListener((v) =>
            {
                StateTransfer.volume = (int)v;
            });
        }
    }

}
