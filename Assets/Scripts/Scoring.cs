using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour
{
    public Text [] text;
    private float score;

    public Pause pause;

    public BallDeathAndGameOver bd;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        calculateScore();
        printScore();
    }

    private void printScore() {
        for(int i = 0; i < text.Length; i++)
        {
        text[i].text = "Score: " + score;
        }
    }

    private void calculateScore() {
        if(!bd.endCheck() || pause.getPause()){
        score = Mathf.Floor(Time.timeSinceLevelLoad * 100f);
        }
    }

    public float getScore() {
        return score;
    }

    public void setScore(int s) {
        score = s;
        Debug.Log(score);
    }
}
