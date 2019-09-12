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

    public GameObject northSpawn;
    public GameObject northEastSpawn;
    public GameObject EastSpawn;
    public GameObject SouthEastSpawn;
    public GameObject SouthSpawn;
    public GameObject SouthWestSpawn;
    public GameObject WestSpawn;
    public GameObject NorthWestSpawn;
    
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

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject spawn = null;
            Vector3 startVel = new Vector3(0,0,0);
            if (goingThisWay == Direction.North)
            {
                spawn = northSpawn;
                startVel = new Vector3(0,1,0);
            }else if (goingThisWay == Direction.NorthEast)
            {
                spawn = northEastSpawn;
                startVel = new Vector3(1,1,0);
            }else if (goingThisWay == Direction.East)
            {
                spawn = EastSpawn;
                startVel = new Vector3(1,0,0);
            }else if (goingThisWay == Direction.SouthEast)
            {
                spawn = SouthEastSpawn;
                startVel = new Vector3(1,-1,0);
            }else if (goingThisWay == Direction.South)
            {
                spawn = SouthSpawn;
                startVel = new Vector3(0,-1,0);
            }else if (goingThisWay == Direction.SouthWest)
            {
                spawn = SouthWestSpawn;
                startVel = new Vector3(-1,-1,0);
            }else if (goingThisWay == Direction.West)
            {
                spawn = WestSpawn;
                startVel = new Vector3(-1,0,0);
            }else if (goingThisWay == Direction.NorthWest)
            {
                spawn = NorthWestSpawn;
                startVel = new Vector3(-1,1,0);
            }

            if (spawn != null)
            {
                GameObject _bull = Instantiate(bullet, spawn.transform.position, spawn.transform.rotation);
                _bull.GetComponent<BulletController>().StartingVelocity = startVel;

            }

        }
        
    }
}
