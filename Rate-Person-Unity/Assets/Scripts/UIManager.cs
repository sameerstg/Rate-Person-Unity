using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager _instane;

    [Header("1st Panel")]
    public TMP_InputField nameInput;
    public Slider ageSlider;
    public ToggleGroup gender;

    [Header("2nd Panel")]
    public List<GameObject> attributeText = new List<GameObject>();
    public List<GameObject> attributeInputSlider = new List<GameObject>();
    public GameObject leftPanel;
    public GameObject rightPanel;
    void Awake()
    {
        _instane = this;
    }
    
    public void StartSetting()
    {
        foreach (var attributesName in GameManager.attributesNameList)
        {
            var at = Instantiate(Resources.Load<GameObject>("Text Holder"),leftPanel.transform);
            at.GetComponent<TextMeshProUGUI>().text = attributesName;
            attributeText.Add(at);
        }
        foreach (var attributesName in GameManager.attributesNameList)
        {
            var at = Instantiate(Resources.Load<GameObject>("InputField"),rightPanel.transform);
            attributeInputSlider.Add(at);
        }    
    }
}
