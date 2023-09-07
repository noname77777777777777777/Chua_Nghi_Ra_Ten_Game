using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class ButtonLoadSence : MonoBehaviour
{
    public void LoadSence()
    {
        SceneManager.LoadScene("GamePlay");
    }
}
