using System.IO;
using UnityEngine;

public class JsonReadWriteSystem : MonoBehaviour
{

    public void SaveAData(string fileName, PersonData classObject)
    {
        AllData allDataClass = LoadData(fileName);
        Debug.Log(allDataClass.dataList.Count);
        allDataClass.dataList.Add(classObject);
        SaveDataAll(fileName, allDataClass);
    }



    [ContextMenu("Save")]
    public void TestSave()
    {
        PersonData person = new PersonData((int.Parse(GetLastId(GameManager.allDataFileName))+1).ToString());
        SaveAData(GameManager.allDataFileName, person);
    }
    [ContextMenu("Load")]
    public void TestLoad()
    {
        Debug.Log(GetLastId(GameManager.allDataFileName));
    }

    public string GetLastId(string fileName)
    {
        var allData = LoadData(fileName);
        
        return (allData.dataList.Count).ToString();
    }
    public void SaveDataAll(string fileName, AllData allDataObject)
    {

        string json = JsonUtility.ToJson(allDataObject, true);
        File.WriteAllText(Application.persistentDataPath + "/" + fileName + ".json", json);
    }
    
    public AllData LoadData(string fileName)
    {
        if(File.Exists(Application.persistentDataPath + "/" + GameManager.allDataFileName + ".json"))
        {
            string json = File.ReadAllText(Application.persistentDataPath + "/" + fileName + ".json");
            AllData allData = JsonUtility.FromJson<AllData>(json);
            return allData;
        }
        AllData allData1 = new AllData();
        return allData1;
    }



}
