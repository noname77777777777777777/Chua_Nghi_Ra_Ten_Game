using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;
public class SpriteController : MonoBehaviour
{
    [SerializeField] public SpriteAtlas Atlas;

    [SerializeField] public string SpriteName;
    public void Start()
    {   
        GetComponent<Image>().sprite = Atlas.GetSprite(SpriteName);
    }
  
}

