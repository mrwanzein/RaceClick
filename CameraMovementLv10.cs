using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraMovementLv10 : MonoBehaviour
{
    public Transform raceSet;
    public Transform BG;

    // Update is called once per frame
    void Update()
    {

        switch (raceSet.childCount)
        {
            case 62:
                transform.position = Vector3.Lerp(transform.position, new Vector3(48, 9, transform.position.z), 0.1f);
                BG.position = Vector3.Lerp(BG.position, new Vector3(48, 9, BG.position.z), 0.1f);
                break;
            case 37:
                transform.position = Vector3.Lerp(transform.position, new Vector3(48, 27, transform.position.z), 0.1f);
                BG.position = Vector3.Lerp(BG.position, new Vector3(48, 27, BG.position.z), 0.1f);
                break;
            case 10:
                transform.position = Vector3.Lerp(transform.position, new Vector3(80, 27, transform.position.z), 0.1f);
                BG.position = Vector3.Lerp(BG.position, new Vector3(80, 27, BG.position.z), 0.1f);
                break;
            case 0:
                if (LoadSceneOnClickForMainMenu.isPlayingCampaign)
                {
                    PlayerPrefs.SetInt("HighScoreInt", SavingHighScore.scoreForHighScore);
                    PlayerPrefs.SetString("HighScore", System.DateTime.Now.ToShortDateString() + " - " + SavingHighScore.scoreForHighScore);

                    if (PlayerPrefs.GetInt("Level10Unlocked") != 10)
                    {
                        PlayerPrefs.SetInt("Level10Unlocked", 10);
                    }
                }
                break;
        }
    }
}
