using UnityEngine;
using UnityEngine.UI;

public class SavingHighScore : MonoBehaviour
{

    public Text highScoreText;
    public static int scoreForHighScore = 0;

    void Start()
    {

        if (scoreForHighScore >= PlayerPrefs.GetInt("HighScoreInt"))
        {
             highScoreText.fontSize = 110;
             highScoreText.text = PlayerPrefs.GetString("HighScore");
             PlayerPrefs.SetInt("HighScoreInt", scoreForHighScore);
             scoreForHighScore = 0;
        }
        else
        {
            highScoreText.text = PlayerPrefs.GetString("HighScore");
        }
        
    }


}
