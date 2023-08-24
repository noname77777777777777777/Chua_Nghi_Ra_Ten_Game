using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DailylogingManager : MonoBehaviour
{
    [SerializeField] private GameObject DialyReward;
    [SerializeField] private TextMeshProUGUI Coin_UI;
    [SerializeField] private int Value_Reward;
    public int value_coin = 0;
    public void AddCoin_Dailyreward()
    {
        value_coin += Value_Reward;
        Coin_UI.text = value_coin.ToString();
        DialyReward.SetActive(false);
    }
    private void Start()
    {
        DialyReward.SetActive(true);
    }
}
