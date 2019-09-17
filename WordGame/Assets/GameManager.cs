using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int level = 0;
    public int currentAnswer = 0;
    public float gradeK;
    public float grade1;
    public float grade2;
    public class MathProblem
    {
        public string problem;
        public int answer;
        public bool correct = false;
        public MathProblem(string _pro, int _ans)
        {
            problem = _pro;
            answer = _ans;
        }
    }

    public MathProblem Kp0 = new MathProblem("1+1", 2);
    public MathProblem Kp1 = new MathProblem("1+2", 3);
    public MathProblem Kp2 = new MathProblem("3+1", 4);
    public MathProblem Kp3 = new MathProblem("2+2", 4);
    public MathProblem Kp4 = new MathProblem("5+1", 6);
    public MathProblem Kp5 = new MathProblem("2+3", 5);
    public MathProblem Kp6 = new MathProblem("6+2", 8);
    public MathProblem Kp7 = new MathProblem("7+1", 8);
    public MathProblem Kp8 = new MathProblem("8+1", 9);
    public MathProblem Kp9 = new MathProblem("2+5", 7);

   public MathProblem[] kindergardenProblems = new MathProblem[10];
    

    // Start is called before the first frame update
    void Start()
    {
        kindergardenProblems[0] = Kp0;
        kindergardenProblems[1] = Kp1;
        kindergardenProblems[2] = Kp2;
        kindergardenProblems[3] = Kp3;
        kindergardenProblems[4] = Kp4;
        kindergardenProblems[5] = Kp5;
        kindergardenProblems[6] = Kp6;
        kindergardenProblems[7] = Kp7;
        kindergardenProblems[8] = Kp8;
        kindergardenProblems[9] = Kp9;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Correct(MathProblem mp)
    {
        if (!mp.correct)
        {
            mp.correct = true;
        }
    }

    public string GiveQuestion()
    {
        int random = Random.Range(0, 9);
        for (int i = random; i < 10; i++)
        {
            if(level == 0)
            {
                if (!kindergardenProblems[i].correct)
                {
                    currentAnswer = kindergardenProblems[i].answer;
                    return kindergardenProblems[i].problem;
                }
            }
        }
        for (int i = 0; i < 10; i++)
        {
            if (level == 0)
            {
                if (!kindergardenProblems[i].correct)
                {
                    currentAnswer = kindergardenProblems[i].answer;
                    return kindergardenProblems[i].problem;
                }
            }
        }

        for (int i = 0; i < 10; i++)
        {
            if (level == 0)
            {
                if (!kindergardenProblems[i].correct)
                {
                    kindergardenProblems[i].correct = false; //reset problems if u asnwered thema ll
                    
                }
            }
        }

        for (int i = random; i < 10; i++)
        {
            if (level == 0)
            {
                if (!kindergardenProblems[i].correct)
                {
                    currentAnswer = kindergardenProblems[i].answer;
                    return kindergardenProblems[i].problem;
                }
            }
        }
        for (int i = 0; i < 10; i++)
        {
            if (level == 0)
            {
                if (!kindergardenProblems[i].correct)
                {
                    currentAnswer = kindergardenProblems[i].answer;
                    return kindergardenProblems[i].problem;
                }
            }
        }
        return "";
        
    }
}
