using UnityEngine;
using UnityEngine.UI;


public class CalculateScore : MonoBehaviour
{

    public int score;
    public int maxScore = 1000;

    public Transform goal;

    public TextMesh debugField;

    void Start()
    {
    }

    void Update()
    {
        score = calculateScore();
        debugField.text = "" + score;
    }

    private int calculateScore()
    {
        float distance = Vector3.Distance(gameObject.transform.position, goal.transform.position);
        return (int)(1 / distance * maxScore);
    }

}
