

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseObject : MonoBehaviour
{
    [SerializeField] private GameObject Close;

    public void Closedialog()
    {
        Close.SetActive(false);
    }
}
