using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float movement;

    public Boolean up;

    public Boolean left;

    public GameObject bullet;
    
    private  Boolean canShoot = true;

    private GameObject _bull = null;

    public GameObject Spawn;
    
    public enum Direction //this declares a type of variable named direction 
    {
        North = 0,
        NorthEast = 1,
        East = 2,
        SouthEast = 3,
        South = 4,
        SouthWest = 5,
        West = 6,
        NorthWest = 7
        
    }

    private Direction goingThisWay;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))   //vertical movement
        {
            transform.Translate(0,movement * Time.deltaTime, 0);
        }else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0,-movement * Time.deltaTime, 0);
        }
        
        if (Input.GetKey(KeyCode.D))  //horizontal movement
        {
            transform.Translate(movement * Time.deltaTime, 0, 0);
        }else if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-movement * Time.deltaTime, 0, 0);
        }
        
        //direction monitoring
        if (Input.GetKey(KeyCode.W))
        {
            if (Input.GetKey(KeyCode.D))
            {
                goingThisWay = Direction.NorthEast;
            }else if (Input.GetKey(KeyCode.A))
            {
                goingThisWay = Direction.NorthWest;
            }
            else
            {
                goingThisWay = Direction.North;
            }
        }else if (Input.GetKey(KeyCode.S))
        {
            if (Input.GetKey(KeyCode.D))
            {
                goingThisWay = Direction.SouthEast;
            }else if (Input.GetKey(KeyCode.A))
            {
                goingThisWay = Direction.SouthWest;
            }
            else
            {
                goingThisWay = Direction.South;
            }
        }else if (Input.GetKey(KeyCode.D))
        {
            goingThisWay = Direction.East;
        }else if (Input.GetKey(KeyCode.A))
        {
            goingThisWay = Direction.West;
        }

        //print(goingThisWay.ToString());

        if (Input.GetMouseButtonDown(0))
        {
            if (_bull != null)
            {
                Destroy(_bull);
            }
            _bull = Instantiate(bullet, Spawn.transform.position, Spawn.transform.rotation);

        }
    }
}
