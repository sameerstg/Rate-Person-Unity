using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class PersonData
{
     public string id;
     public string name;
     public string age;
     public string gender;
     public string intellectualLevel;
     public string processingLevel;
     public string memoryLevel;
     public string visualLevel;
     public string emotionalLevel;
     public string perceptionalLevel;
    
    public PersonData(string id)
    {
        this.id = id;
    }

    string appearenceLevel;
     string maturityLevel;
     string ethicalLevel;
     string patienceLevel;
     string rating;

    public string Id { get => id; set => id = value; }
    public string Name { get => name; set => name = value; }
    public string Age { get => age; set => age = value; }
    public string Gender { get => gender; set => gender = value; }
    public string IntellectualLevel { get => intellectualLevel; set => intellectualLevel = value; }
    public string ProcessingLevel { get => processingLevel; set => processingLevel = value; }
    public string MemoryLevel { get => memoryLevel; set => memoryLevel = value; }
    public string VisualLevel { get => visualLevel; set => visualLevel = value; }
    public string EmotionalLevel { get => emotionalLevel; set => emotionalLevel = value; }
    public string PerceptionalLevel { get => perceptionalLevel; set => perceptionalLevel = value; }
    public string AppearenceLevel { get => appearenceLevel; set => appearenceLevel = value; }
    public string MaturityLevel { get => maturityLevel; set => maturityLevel = value; }
    public string EthicalLevel { get => ethicalLevel; set => ethicalLevel = value; }
    public string PatienceLevel { get => patienceLevel; set => patienceLevel = value; }
    public string Rating { get => rating; set => rating = value; }
}
[System.Serializable]
public class AllData
{
    public List<PersonData> dataList = new List<PersonData>();
}