using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public static DataManager _instance;
    void Awake()
    {
        _instance = this;
    }
    public void TakeGeneralInfo(string name,int age,string gender)
    {
        JsonReadWriteSystem save = new JsonReadWriteSystem();
        
        PersonData personData = new PersonData((int.Parse(save.GetLastId(GameManager.allDataFileName))+1).ToString());
        personData.Name = name;
        personData.Age = age.ToString();
        personData.Gender = gender;
        CreatePersonData(personData);
    }public void TakeAttributesInfo()
    {

    }
    public void CreatePersonData(PersonData personData)
    {
        JsonReadWriteSystem save = new JsonReadWriteSystem();
        save.SaveAData(GameManager.allDataFileName,personData);
    }
}
