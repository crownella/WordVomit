using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    public GameObject bullet;

    public int health = 30;
    

    private GameObject _bull = null;

    public GameObject Spawn;
    public bool dead = false;

    public AudioSource audioS;



    public Sprite s1;
    public Sprite s2;
    public Sprite s3;
    public Sprite s4;
    public Sprite s5;
    public Sprite s6;
    public Sprite s7;
    public Sprite s8;
    public Sprite s9;
    public Sprite s10;
    public Sprite s11;
    public Sprite s12;
    public Sprite s13;
    public Sprite s14;
    public Sprite s15;
    public Sprite s16;
    public Sprite s17;
    public Sprite s18;
    public Sprite s19;
    public Sprite s20;
    public Sprite s21;
    public Sprite s22;
    public Sprite s23;
    public Sprite s24;
    public Sprite s25;
    public Sprite s26;
    public Sprite s27;
    public Sprite s28;
    public Sprite s29;
    public Sprite s30;

    // Start is called before the first frame update
    void Start()
    {
        audioS = this.gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        updateSprite();
        if(health <= 0)
        {
            GetComponent<SpriteRenderer>().color = Color.red;
            dead = true;
            Time.timeScale = 0;
        }
        /* my movement code i didnt end up using
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
        */
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("abstractIntruders")
        }

        if (Input.GetKeyDown(KeyCode.Keypad1) && !dead)
        {
            _bull = Instantiate(bullet, Spawn.transform.position, Spawn.transform.rotation);
            _bull.GetComponent<BulletController>().bulletValue = 1;

        }
        else if (Input.GetKeyDown(KeyCode.Keypad2) && !dead)
        {
            _bull = Instantiate(bullet, Spawn.transform.position, Spawn.transform.rotation);
            _bull.GetComponent<BulletController>().bulletValue = 2;

        }
        else if (Input.GetKeyDown(KeyCode.Keypad3) && !dead)
        {
            _bull = Instantiate(bullet, Spawn.transform.position, Spawn.transform.rotation);
            _bull.GetComponent<BulletController>().bulletValue = 3;

        }
        else if (Input.GetKeyDown(KeyCode.Keypad4) && !dead)
        {
            _bull = Instantiate(bullet, Spawn.transform.position, Spawn.transform.rotation);
            _bull.GetComponent<BulletController>().bulletValue = 4;

        }
        else if (Input.GetKeyDown(KeyCode.Keypad5) && !dead)
        {
            _bull = Instantiate(bullet, Spawn.transform.position, Spawn.transform.rotation);

            _bull.GetComponent<BulletController>().bulletValue = 5;

        }
        else if (Input.GetKeyDown(KeyCode.Keypad6) && !dead)
        {
            _bull = Instantiate(bullet, Spawn.transform.position, Spawn.transform.rotation);
            _bull.GetComponent<BulletController>().bulletValue = 6;

        }
        else if (Input.GetKeyDown(KeyCode.Keypad7) && !dead)
        {
            _bull = Instantiate(bullet, Spawn.transform.position, Spawn.transform.rotation);
            _bull.GetComponent<BulletController>().bulletValue = 7;

        }
        else if (Input.GetKeyDown(KeyCode.Keypad8) && !dead)
        {
            _bull = Instantiate(bullet, Spawn.transform.position, Spawn.transform.rotation);
            _bull.GetComponent<BulletController>().bulletValue = 8;

        }
        else if (Input.GetKeyDown(KeyCode.Keypad9) && !dead)
        {
            _bull = Instantiate(bullet, Spawn.transform.position, Spawn.transform.rotation);
            _bull.GetComponent<BulletController>().bulletValue = 9;

        }
        else if (Input.GetKeyDown(KeyCode.Q) && !dead)
        {
            _bull = Instantiate(bullet, Spawn.transform.position, Spawn.transform.rotation);
            _bull.GetComponent<BulletController>().bulletValue = 1;
        }
        else if (Input.GetKeyDown(KeyCode.W) && !dead)
        {
            _bull = Instantiate(bullet, Spawn.transform.position, Spawn.transform.rotation);
            _bull.GetComponent<BulletController>().bulletValue = 2;

        }
        else if (Input.GetKeyDown(KeyCode.E) && !dead)
        {
            _bull = Instantiate(bullet, Spawn.transform.position, Spawn.transform.rotation);
            _bull.GetComponent<BulletController>().bulletValue = 3;

        }
        else if (Input.GetKeyDown(KeyCode.R) && !dead)
        {
            _bull = Instantiate(bullet, Spawn.transform.position, Spawn.transform.rotation);
            _bull.GetComponent<BulletController>().bulletValue = 4;

        }
        else if (Input.GetKeyDown(KeyCode.T) && !dead)
        {
            _bull = Instantiate(bullet, Spawn.transform.position, Spawn.transform.rotation);
            _bull.GetComponent<BulletController>().bulletValue = 5;

        }
        else if (Input.GetKeyDown(KeyCode.Y) && !dead)
        {
            _bull = Instantiate(bullet, Spawn.transform.position, Spawn.transform.rotation);
            _bull.GetComponent<BulletController>().bulletValue = 6;

        }
        else if (Input.GetKeyDown(KeyCode.U) && !dead)
        {
            _bull = Instantiate(bullet, Spawn.transform.position, Spawn.transform.rotation);
            _bull.GetComponent<BulletController>().bulletValue = 7;

        }
        else if (Input.GetKeyDown(KeyCode.I) && !dead)
        {
            _bull = Instantiate(bullet, Spawn.transform.position, Spawn.transform.rotation);
            _bull.GetComponent<BulletController>().bulletValue = 8;

        }
        else if (Input.GetKeyDown(KeyCode.O) && !dead)
        {
            _bull = Instantiate(bullet, Spawn.transform.position, Spawn.transform.rotation);
            _bull.GetComponent<BulletController>().bulletValue = 9;

        }

    }

    public void updateSprite()
    {
        if (health == 1 || health == -1)
        {
            GetComponent<SpriteRenderer>().sprite = s1;
        }
        else if (health == 2 || health == -2)
        {
            GetComponent<SpriteRenderer>().sprite = s2;
        }
        else if (health == 3 || health == -3)
        {
            GetComponent<SpriteRenderer>().sprite = s3;
        }
        else if (health == 4 || health == -4)
        {
            GetComponent<SpriteRenderer>().sprite = s4;
        }
        else if (health == 5 || health == -5)
        {
            GetComponent<SpriteRenderer>().sprite = s5;
        }
        else if (health == 6 || health == -6)
        {
            GetComponent<SpriteRenderer>().sprite = s6;
        }
        else if (health == 7 || health == -7)
        {
            GetComponent<SpriteRenderer>().sprite = s7;
        }
        else if (health == 8 || health == -8)
        {
            GetComponent<SpriteRenderer>().sprite = s8;
        }
        else if (health == 9 || health == -9)
        {
            GetComponent<SpriteRenderer>().sprite = s9;
        }
        else if (health == 10 || health == -10)
        {
            GetComponent<SpriteRenderer>().sprite = s10;
        }
        else if (health == 11 || health == -11)
        {
            GetComponent<SpriteRenderer>().sprite = s11;
        }
        else if (health == 12 || health == -12)
        {
            GetComponent<SpriteRenderer>().sprite = s12;
        }
        else if (health == 13 || health == -13)
        {
            GetComponent<SpriteRenderer>().sprite = s13;
        }
        else if (health == 14 || health == -14)
        {
            GetComponent<SpriteRenderer>().sprite = s14;
        }
        else if (health == 15 || health == -15)
        {
            GetComponent<SpriteRenderer>().sprite = s15;
        }
        else if (health == 16 || health == -16)
        {
            GetComponent<SpriteRenderer>().sprite = s16;
        }
        else if (health == 17 || health == -17)
        {
            GetComponent<SpriteRenderer>().sprite = s17;
        }
        else if (health == 18 || health == -18)
        {
            GetComponent<SpriteRenderer>().sprite = s18;
        }
        else if (health == 19 || health == -19)
        {
            GetComponent<SpriteRenderer>().sprite = s19;
        }
        else if (health == 20 || health == -20)
        {
            GetComponent<SpriteRenderer>().sprite = s20;
        }
        else if (health == 21 || health == -21)
        {
            GetComponent<SpriteRenderer>().sprite = s21;
        }
        else if (health == 22 || health == -22)
        {
            GetComponent<SpriteRenderer>().sprite = s22;
        }
        else if (health == 23 || health == -23)
        {
            GetComponent<SpriteRenderer>().sprite = s23;
        }
        else if (health == 24 || health == -24)
        {
            GetComponent<SpriteRenderer>().sprite = s24;
        }
        else if (health == 25 || health == -25)
        {
            GetComponent<SpriteRenderer>().sprite = s25;
        }
        else if (health == 26 || health == -26)
        {
            GetComponent<SpriteRenderer>().sprite = s26;
        }
        else if (health == 27 || health == -27)
        {
            GetComponent<SpriteRenderer>().sprite = s27;
        }
        else if (health == 28 || health == -28)
        {
            GetComponent<SpriteRenderer>().sprite = s28;
        }
        else if (health == 29 || health == -29)
        {
            GetComponent<SpriteRenderer>().sprite = s29;
        }
        else if (health == 30 || health == -30)
        {
            GetComponent<SpriteRenderer>().sprite = s30;
        }
    }
}
