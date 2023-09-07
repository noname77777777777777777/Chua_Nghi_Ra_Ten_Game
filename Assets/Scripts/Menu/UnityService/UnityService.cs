using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UnityService : MonoBehaviour
{
    [SerializeField] private GameObject getobject;

    public String getVersionUnity()
    {
        return Application.version;
    }
    private void Start()
    {
        getobject.GetComponent<TextMeshProUGUI>().text = "Version " + getVersionUnity();
    }
    
}
