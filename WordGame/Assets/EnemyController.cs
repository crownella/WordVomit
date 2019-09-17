using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class EnemyController : MonoBehaviour
{
    public GameManager gM;
    public float health;
    public int correctAnswer;
    public float pauseBetweenQs;

    public Text problem;
   
    // Start is called before the first frame update
    void Start()
    {
        gM = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        StartCoroutine("AskQuestion");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
 

    IEnumerator AskQuestion()
    {
        string question = gM.GiveQuestion();
        problem.text = question;
        correctAnswer = gM.currentAnswer;

        yield return new WaitForSeconds(pauseBetweenQs);
        yield return StartCoroutine("AskQuestion");
    }


    
    /* //attempted fiel reading
    void readTextFile(string file_path)
    {
        StreamReader reader = new StreamReader(file_path);
        while (!reader.EndOfStream)
        {
            string input = reader.ReadLine();
            print(input);
            string answer = reader.ReadLine();
            print(answer);
        }
    }
    */
}
