using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject enemy;
    public GameObject[] spawns = new GameObject[48];
    public int enemiesKilled;
    public int difficultyModifier; //set to 2
    public float baseSpawnRate;
    public int SpawnModifier;
    public float minSpawndelay;
    public int score;

    public Text scoreT;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("SpawnEnemies");
    }

    // Update is called once per frame
    void Update()
    {
        scoreT.text = score.ToString();
    }

    void SpawnEnemy()
    {
        int tmphealth = 0;
        int randomSpawn = Random.Range(0, 48);
        int chance = Random.Range(0, 100);
        if (chance > 95)
        {
            tmphealth = Random.Range(25, 30);
        }else if(chance > 88)
        {
            tmphealth = Random.Range(20, 35);
        }
        else if (chance > 78)
        {
            tmphealth = Random.Range(15, 20);
        }
        else if (chance > 63)
        {
            tmphealth = Random.Range(10, 15);
        }
        else if (chance > 60)
        {
            tmphealth = 10;
        }
        else if (chance > 57)
        {
            tmphealth = 9;
        }
        else if (chance > 53)
        {
            tmphealth = 8;
        }
        else if (chance > 48)
        {
            tmphealth = 7;
        }
        else if (chance > 42)
        {
            tmphealth = 6;
        }
        else if (chance > 35)
        {
            tmphealth = 5;
        }
        else if (chance > 27)
        {
            tmphealth = 4;
        }
        else if (chance > 19)
        {
            tmphealth = 3;
        }
        else if (chance > 10)
        {
            tmphealth = 2;
        }
        else
        {
            tmphealth = 1;
        }

        tmphealth +=  enemiesKilled / difficultyModifier ; //increase difficulty when more are killed
        if(tmphealth > 30)
        {
            tmphealth = 30; //make sure it doesnt go over 30
        }

        GameObject tmp = Instantiate(enemy, spawns[randomSpawn].transform.position, spawns[randomSpawn].transform.rotation);
        tmp.GetComponent<EnemyController>().health = tmphealth;


    }

    IEnumerator SpawnEnemies()
    {
        SpawnEnemy();
        float tmpSpawnDelay = baseSpawnRate - (enemiesKilled / SpawnModifier);
        if(tmpSpawnDelay < minSpawndelay)
        {
            tmpSpawnDelay = minSpawndelay;
        }
        yield return new WaitForSeconds(tmpSpawnDelay);
        yield return StartCoroutine("SpawnEnemies");
    }

}
