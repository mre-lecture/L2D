using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class CalculateScore : MonoBehaviour
{
    public Text debugField;
    public int maxScore = 1000;
    public Transform goal;
    static int score = 0;
    

    void Start()
    {

    }

    void Update()
    {
        calculateScore();
        returnToMenu();
    }

    public int calculateScore()
    {
        float distance = Vector3.Distance(gameObject.transform.position, goal.transform.position);
        return (int)(1 / distance * maxScore);
        
    }
     public void returnToMenu()
    {
        int leftTime = (30 - (int)Time.time);
        debugField.text = "Time left: " + leftTime + " Seconds";
        if (leftTime <= 0.0)
        {
            debugField.text = "Your Score is: " + calculateScore();
            if (leftTime <= -2)
            {
                Application.LoadLevel("MenuScene");
            }
        }
    }

    public void loadMenu(float leftTime)
    {
        if (leftTime <= 0.0)
        {
            int score = calculateScore();
            debugField.text = "Your Score is:" + score + "!";
            Application.LoadLevel("MenuScene");
        }
    }
}
