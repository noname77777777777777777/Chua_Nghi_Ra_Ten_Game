using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;
using TMPro;
public class Song_menu : MonoBehaviour
{

     [SerializeField] private Button song;
     [SerializeField] private AudioSource playsong;
    [SerializeField] private List<AudioClip> _listsong = new List<AudioClip>();
     private int song_other = 0;
     public void playsongnext()
    {
         if (song_other < _listsong.Count)
        {
             playsong.clip = _listsong[song_other];
             playsong.Play();
             if (song_other != 0)
             {
                 Debug.Log("name : " + _listsong[song_other].name);
             }
             song_other++;   
         }
        else
         {
             song_other = 0;
        }
    }
        

    public void Start()
    {
        playsongnext();
    }
}
