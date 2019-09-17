using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    //public Vector3 StartingVelocity = new Vector3(0,0,0);
    public Vector3 targetPosition = new Vector3(0, 0, 0);
    public  Vector3 velocity = new Vector3(0, 0, 0);

    public float speed;
    public float maxDis;
    public int number;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition); //mouse 3d pos
        Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y); //mouse 2d pos
        targetPosition = mousePos2D; //set target pos
        
        //transform.Translate(StartingVelocity * speed * Time.deltaTime); 

        Vector3 heading = (transform.position - targetPosition); 
        float distance = heading.magnitude;
        velocity = heading / distance; //direction = heading/distance  https://docs.unity3d.com/Manual/DirectionDistanceFromOneObjectToAnother.html


        print(velocity.ToString());
       

        

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
            other.GetComponent<EnemyController>().health -= 1;
            Destroy(gameObject);
        }
        
    }

    public Vector3 Calculate(Vector3 distance, Vector3 _magnitude)
    {
        float tmpX = distance.x;
        float tmpY = distance.y;
        return new Vector3(0, 0, 0);
        
    }
}
