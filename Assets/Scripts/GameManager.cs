using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager _instance;
    public static List<string> attributesNameList;
    public static string allDataFileName = "AllPersonData";
    void Awake()
    {
        _instance = this;
    }
    void Start()
    {
        SetAttributeList();
        UIManager._instane.StartSetting();
    }
    void SetAttributeList()
    {
        attributesNameList = new List<string>();
        PersonData p = new PersonData("69");
        foreach (var item in p.GetType().GetProperties())
        {
            attributesNameList.Add(item.Name);

        }
        attributesNameList.RemoveAt(0);
        attributesNameList.RemoveAt(0);
        attributesNameList.RemoveAt(0);
        attributesNameList.RemoveAt(0);
        attributesNameList.Remove(attributesNameList[attributesNameList.Count-1]);

    }
    public void Submit1st()
    {
        /*
                foreach (var toggle in UIManager._instane.gender.ActiveToggles())
                {
                    print(toggle.gameObject.name);
                    if (toggle.isOn)
                    {
        */

        var t = UIManager._instane.gender.gameObject.transform;

        if (t.GetChild(0).GetComponent<Toggle>().isOn)
        {
            print(UIManager._instane.nameInput.text);
            print((int)UIManager._instane.ageSlider.value);
            print(DataManager._instance);
            DataManager._instance.TakeGeneralInfo(UIManager._instane.nameInput.text, (int)UIManager._instane.ageSlider.value, "Male");

        }
        else if(t.GetChild(1).GetComponent<Toggle>().isOn)
        {
            DataManager._instance.TakeGeneralInfo(UIManager._instane.nameInput.text, (int)UIManager._instane.ageSlider.value, "Female");

        }



    }
    public void Submit2nd()
    {
        float average = 0;
        float value = 0;
        float n = 0;
        foreach (var slider in UIManager._instane.attributeInputSlider)
        {
            value += slider.GetComponent<Slider>().value;
            n += 1;
        }
        average = value / n;
        print(average);
    }
}
