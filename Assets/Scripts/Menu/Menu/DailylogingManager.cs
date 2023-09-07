using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class DailylogingManager : MonoBehaviour
{
    [SerializeField] private GameObject DialyReward;
    private DateTime lastPopupTime;
    [SerializeField] private TextMeshProUGUI Coin_UI;
    [SerializeField] private int Value_Reward;
    public DataServiceManager data;
    public Inventory inventory ;
    private int value_coin = 0;
    public  int getCoin()
    {
        return value_coin;
    }

    public void setCoin(int coin)
    {
        value_coin = coin;
    }
    public void AddCoin_Dailyreward()
    {
        value_coin += Value_Reward;
        Coin_UI.text = value_coin.ToString();
        Debug.Log(inventory.coin);
        data.inventory.coin += getCoin();
        data.SaveDataToJson();
        DialyReward.SetActive(false);
    }
    public void CheckPopUpStatus()
    {
        TimeSpan timeSincelastpopup = DateTime.Now - lastPopupTime;
        if (timeSincelastpopup.TotalHours >= 24)
        {
            DialyReward.SetActive(true);
        }
    }
    public void ClosePopup()
    {
        lastPopupTime = DateTime.Now;
        PlayerPrefs.SetString("LastPopUpTime",lastPopupTime.Ticks.ToString());
        DialyReward.SetActive(false);
    }
    public void LoadDataJsonDaily()
    {
        data.LoadDataJson();
        value_coin = data.inventory.coin;
        Coin_UI.text = value_coin.ToString();
        data.SaveDataToJson();
    }
    private void Start()
    {
        LoadDataJsonDaily();
       
    }

   
}

