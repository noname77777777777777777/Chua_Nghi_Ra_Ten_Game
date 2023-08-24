using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;
using ColorUtility = UnityEngine.ColorUtility;

public class Many_SpriteController : MonoBehaviour
{
    [SerializeField] private SpriteAtlas Atlas;

    [SerializeField] private List<string> NameAtlas;

    private Image sprite;

    [SerializeField] private GameObject Showtext_On;
    [SerializeField] private GameObject Showtext_Off;
    [SerializeField] private string Text_On;
    [SerializeField] private string Text_Off;

    [SerializeField] private GameObject Sound;
    
    private int count = 0;
    // Start is called before the first frame update
    public void Start()
    {
        sprite = GetComponent<Image>();
        Change_Option_Setting();
    }

    public void Change_Option_Setting()
    {
        Showtext_On.GetComponent<TextMeshProUGUI>().text = Text_Off;
        Showtext_Off.GetComponent<TextMeshProUGUI>().text = Text_On;
        
        if (count % 2 == 0)
        {
            sprite.sprite = Atlas.GetSprite(NameAtlas[0]);
            Showtext_On.SetActive(true);
            Showtext_Off.SetActive(false);
            Sound.GetComponent<AudioSource>().Play();
        }
        else
        {
            sprite.sprite = Atlas.GetSprite(NameAtlas[1]);
            Showtext_On.SetActive(false);
            Showtext_Off.SetActive(true);
            Sound.GetComponent<AudioSource>().Pause();
        }
        count++;
    }
}
