using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class EnemyController : MonoBehaviour
{
    public GameManager gM;
    public Vector3 targetPosition = new Vector3(0, -4, 0);
    public Vector3 velocity = new Vector3(0, 0, 0);
    public float speed;
    public float startingSpeed;
    public float speedIncrease;
    public float speedModifier;
    public int health;

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
        gM = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        Vector3 heading = (transform.position - targetPosition);
        float distance = heading.magnitude;
        velocity = heading / distance;
        speed = startingSpeed - (health / speedModifier); 
    }

    // Update is called once per frame
    void Update()
    {
        speed = startingSpeed - (health / speedModifier);
        if (health < 0)
        {
            GetComponent<SpriteRenderer>().color = Color.red;
            if(speed == startingSpeed)
            {
                speed += speedIncrease;
            }
        }else if(health == 0)
        {
            gM.enemiesKilled += 1;
            gM.score += 1;
            Destroy(gameObject);
            
        }
        else
        {
            GetComponent<SpriteRenderer>().color = Color.white;
        }
        updateSprite();
        transform.Translate(velocity * -speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Bullet")
        {
            //other.GetComponent<EnemyController>().health -= bulletValue;
            
        }
        else if (other.tag == "Player")
        {
            if(health > 0)
            {
                other.GetComponent<PlayerController>().health -= health;
            }
            else
            {
                other.GetComponent<PlayerController>().health -= Mathf.Abs(health);
            }
            other.GetComponent<AudioSource>().Play();
            gM.enemiesKilled += 1;
            Destroy(gameObject);
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
