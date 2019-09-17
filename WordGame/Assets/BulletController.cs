using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    //public Vector3 StartingVelocity = new Vector3(0,0,0);
    public Vector3 targetPosition = new Vector3(0, 0, 0);
    public  Vector3 velocity = new Vector3(0, 0, 0);

    public float speed;

    public int bulletValue;

    public Sprite s1;
    public Sprite s2;
    public Sprite s3;
    public Sprite s4;
    public Sprite s5;
    public Sprite s6;
    public Sprite s7;
    public Sprite s8;
    public Sprite s9;



    // Start is called before the first frame update
    void Start()
    {
        updateSprite();

        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition); //mouse 3d pos
        Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y); //mouse 2d pos
        targetPosition = mousePos2D; //set target pos
        
        //transform.Translate(StartingVelocity * speed * Time.deltaTime); 

        Vector3 heading = (transform.position - targetPosition); 
        float distance = heading.magnitude;
        velocity = heading / distance; //direction = heading/distance  https://docs.unity3d.com/Manual/DirectionDistanceFromOneObjectToAnother.html


       
       
        
        

    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = Vector3.MoveTowards(transform.position, targetPosition, maxDis);
        transform.Translate(velocity * -speed * Time.deltaTime);


        



    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            int tmpHealth = other.GetComponent<EnemyController>().health;
            if (tmpHealth < bulletValue)
            {
                int tmp = bulletValue - tmpHealth;
                other.GetComponent<EnemyController>().health = -tmp;
               
            }
            else if(tmpHealth == bulletValue)
            {
                other.GetComponent<EnemyController>().health = 0;
                
            }
            else
            {
                other.GetComponent<EnemyController>().health -= bulletValue;
                
            }
            Destroy(gameObject);

        }
        
    }

    public Vector3 Calculate(Vector3 distance, Vector3 _magnitude)
    {
        float tmpX = distance.x;
        float tmpY = distance.y;
        return new Vector3(0, 0, 0);
        
    }

    public void updateSprite()
    {
        if(bulletValue == 1)
        {
            GetComponent<SpriteRenderer>().sprite = s1;
        }
        else if(bulletValue == 2)
        {
            GetComponent<SpriteRenderer>().sprite = s2;
        }
        else if (bulletValue == 3)
        {
            GetComponent<SpriteRenderer>().sprite = s3;
        }
        else if (bulletValue == 4)
        {
            GetComponent<SpriteRenderer>().sprite = s4;
        }
        else if (bulletValue == 5)
        {
            GetComponent<SpriteRenderer>().sprite = s5;
        }
        else if (bulletValue == 6)
        {
            GetComponent<SpriteRenderer>().sprite = s6;
        }
        else if (bulletValue == 7)
        {
            GetComponent<SpriteRenderer>().sprite = s7;
        }
        else if (bulletValue == 8)
        {
            GetComponent<SpriteRenderer>().sprite = s8;
        }
        else if (bulletValue == 9)
        {
            GetComponent<SpriteRenderer>().sprite = s9;
        }
    }
}
