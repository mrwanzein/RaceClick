using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour {

    bool doOnce;
    bool doOnce1;
    Text scoreText;

    public static int score = 0;
    public static int backgroundScore = 0;
    public GameObject finish;
    public GameObject endLevel;
    public GameObject raceSet;
    public GameObject ScoreIndicator;

    // Use this for initialization
    void Start () {
        scoreText = GetComponent<Text>();
        doOnce = true;
        doOnce1 = false;
    }
	
	// Update is called once per frame
	void Update () {

        Text[] endLvlPanel = endLevel.GetComponentsInChildren<Text>();
        int timerToScore = Mathf.FloorToInt(TimerDisplay.timerOnPlay);
        string playTimer = GameObject.Find("Timer").GetComponent<TimerDisplay>().timer.text;

        scoreText.text = "Score: " + score;

        if (finish.transform.localScale.x == 0 && finish.transform.localScale.y == 0 && doOnce1 == false)
        {
            doOnce1 = true;
            endLevel.SetActive(true);
            endLvlPanel[1].text = "    Final Time: " + playTimer;

        }


        if (raceSet.transform.childCount == 0 && timerToScore <= 70 && doOnce == true)
        {
            doOnce = false;
            endLvlPanel[0].text = "   Base Score: " + backgroundScore;
            endLvlPanel[2].text = "    Final Score: " + score;
            ScoreIndicator.GetComponent<Text>().text = "+ 1000";
            ScoreIndicator.GetComponent<Animator>().Play("ScoreGained");
            score += 1000;
            SavingHighScore.scoreForHighScore += 1000;
        }

        else if (raceSet.transform.childCount == 0 && timerToScore <= 80 && doOnce == true)
        {
            doOnce = false;
            endLvlPanel[0].text = "   Base Score: " + backgroundScore;
            endLvlPanel[2].text = "    Final Score: " + score;
            ScoreIndicator.GetComponent<Text>().text = "+ 750";
            ScoreIndicator.GetComponent<Animator>().Play("ScoreGained");
            score += 750;
            SavingHighScore.scoreForHighScore += 750;
        }

        else if (raceSet.transform.childCount == 0 && timerToScore <= 90 && doOnce == true)
        {
            doOnce = false;
            endLvlPanel[0].text = "   Base Score: " + backgroundScore;
            endLvlPanel[2].text = "    Final Score: " + score;
            ScoreIndicator.GetComponent<Text>().text = "+ 500";
            ScoreIndicator.GetComponent<Animator>().Play("ScoreGained");
            score += 500;
            SavingHighScore.scoreForHighScore += 500;
        }
        else
        {
            endLvlPanel[0].text = "   Base Score: " + backgroundScore;
            endLvlPanel[2].text = "    Final Score: " + score;
        }

    }
}
