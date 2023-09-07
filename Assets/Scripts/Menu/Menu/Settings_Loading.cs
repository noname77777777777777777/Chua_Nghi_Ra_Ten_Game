using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Image = UnityEngine.UI.Image;

public class Settings_Loading : MonoBehaviour
{
    public GameObject changeBG;
    [SerializeField] private string newcolor;
    [SerializeField] private string oddcolor;

    public GameObject Dialog;
    
    public bool isClick;
    public static Color HexToColor(string hex)
    {
        Color color = Color.white;
        if (hex.Length == 7 && hex[0] == '#')
        {
            byte r = (byte)(System.Convert.ToUInt32(hex.Substring(1, 2), 16));
            byte g = (byte)(System.Convert.ToUInt32(hex.Substring(3, 2), 16));
            byte b = (byte)(System.Convert.ToUInt32(hex.Substring(5, 2), 16));
            color = new Color32(r, g, b, 255);
        }
        return color;
    }
    public void ShowDiaLog()
    {
        if (!Dialog.activeSelf)
        {
            changeBG.GetComponent<Image>().color = HexToColor(newcolor);
            isClick = true;
            Dialog.SetActive(true);
        }
        else
        {
            HideDialog();
            isClick = false;
        }
        
    }

    public void HideDialog()
    {
        changeBG.GetComponent<Image>().color = HexToColor(oddcolor);
        isClick = false;
        Dialog.SetActive(false);
    }
    
}
