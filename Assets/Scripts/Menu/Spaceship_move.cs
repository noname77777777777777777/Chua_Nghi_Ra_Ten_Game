using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Spaceship_move : MonoBehaviour
{
    [SerializeField] private Button spaceship;

    [SerializeField] private float move_x = 0f;
    [SerializeField] private float move_y = 0f;

    private int direction = 1;

    public void Debug_move()
    {
        Debug.Log("transform x : "+spaceship.transform.position.x);
        Debug.Log("transform y : "+spaceship.transform.position.y);
        Debug.Log(" rotation x : "+spaceship.transform.rotation.x);
        Debug.Log("rotitaion y : "+spaceship.transform.rotation.y);

    }
    // Start is called before the first frame update
    public void Start()
    {
        spaceship = GetComponent<Button>();
    }
    
    private void Spaceship_Move()
    {
        spaceship.transform.position = new Vector3(spaceship.transform.position.x + move_x *direction* Time.deltaTime,
            spaceship.transform.position.y + move_y *direction* Time.deltaTime);
        if (spaceship.transform.position.x <=530)
        {
            spaceship.transform.position = new Vector3(1648,-119);
        }   
        // if (direction == 1)
        //  {
        //      if (spaceship.transform.position.x <=530)
        //      {
        //          direction *= -1;
        //      }   
        //  }
        //  else
        // {
        //     if (spaceship.transform.position.x >=1648)
        //     {
        //         direction *= -1;
        //     }
        // }
    }
    
    void Update()
    {
        //Debug_move();
        Spaceship_Move();
        
    }
}
