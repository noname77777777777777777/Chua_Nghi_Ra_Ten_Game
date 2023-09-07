using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;
public class Spaceship_move : MonoBehaviour
{
    [SerializeField] private GameObject spaceship;
    private Image ColorSpaceship;
    [SerializeField] private float move_x = 0f;
    [SerializeField] private float move_y = 0f;
    private const float Stop_point = -140f;
    private int direction = 1;
    private float Random_position_x = 0f;
    private float Random_position_y = 0f;
    [SerializeField] private List<string> color_spaceship = new List<string>();
    public void Debug_move()
    {
        Debug.Log("transform x : "+spaceship.transform.position.x);
        Debug.Log("transform y : "+spaceship.transform.position.y);
    }
    // Start is called before the first frame update
    public void Start()
    {
        Debug_move();
        spaceship.GetComponent<GameObject>(); 
        ColorSpaceship = spaceship.GetComponent<Image>();
    }

    private void SpaceShip_Move()
    {
        spaceship.transform.position = new Vector2(spaceship.transform.position.x + move_x *direction* Time.deltaTime,
            spaceship.transform.position.y + move_y *direction* Time.deltaTime);
    }
    
    private void Spaceship_Move()
    {
        SpaceShip_Move();
        if (spaceship.transform.position.x <= Stop_point)
        {
            int random_color = Random.Range(0, color_spaceship.Count);
            ColorSpaceship.color = Settings_Loading.HexToColor(color_spaceship[random_color]);
            Random_position_x = Random.Range(309, 800);
            Random_position_y = Random.Range(-104, -84);
            spaceship.transform.position = new Vector2(Random_position_x,Random_position_y);
            SpaceShip_Move();
        }
    }
    
    void Update()
    {
        Spaceship_Move();
    }
}
