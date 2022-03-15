using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SliderNumber : MonoBehaviour
{
    Slider slider;
    public TextMeshProUGUI sliderText;
    void Start()
    {
        slider = GetComponent<Slider>();
    }
    public void UpdateTextBySlider()
    {
        sliderText.text = Mathf.Round(slider.value).ToString();
    }
}
