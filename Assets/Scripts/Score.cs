using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour {

    public Text uiText;
	// Use this for initialization
	void Start () {
        toString();
    }
	
	// Update is called once per frame
	void Update () {
	}

    //calculate Score
    int calculateScore()
    {
        int score = Random.Range(0, 10);
        return score;
    }

    //print Score text on wall and prints Score
    void toString()
    {
        uiText.text = "Du hast " + calculateScore() + " von 10 Punkten!";
    }
}
