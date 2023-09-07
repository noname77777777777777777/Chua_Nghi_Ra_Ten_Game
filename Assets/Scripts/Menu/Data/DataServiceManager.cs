using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Unity.VisualScripting;
using UnityEngine;
[Serializable] public class Inventory
{
     public int coin;
}

public class DataServiceManager : MonoBehaviour
{ 
    public Inventory inventory;
    public void SaveDataToJson()
    {
        string json = JsonUtility.ToJson(inventory);
        string filepath = Application.persistentDataPath + "/Data.json";
        File.WriteAllText(filepath,json);
    }

    public void LoadDataJson()
    {
        string filepath = Application.persistentDataPath + "/Data.json";
        string inventorydata = System.IO.File.ReadAllText(filepath);
        inventory = JsonUtility.FromJson<Inventory>(inventorydata);
    }
}

