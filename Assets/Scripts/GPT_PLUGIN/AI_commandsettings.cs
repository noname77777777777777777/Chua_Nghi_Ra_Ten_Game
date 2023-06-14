using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "AIcommandsSettings",menuName = "AICommand/AI Commad Sttings")]
public class AI_commandsettings : ScriptableObject
{
    //time request
    [SerializeField] private float timeout = 10f;
    // key iap
    [SerializeField] private string keyiap = "";
    public float Timeout => timeout;
    public string IAPkey => keyiap;
}
