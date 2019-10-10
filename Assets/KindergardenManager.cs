using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KindergardenManager : MonoBehaviour
{
    public GameManager gM;
    public GameObject teacher;
    public GameObject teacherSpawn;
    // Start is called before the first frame update
    void Start()
    {
        gM = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();

        Instantiate(teacher, teacherSpawn.transform.position, teacherSpawn.transform.rotation); //spawn teacher
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
