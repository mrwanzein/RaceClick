using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneOnClickForMainMenu : MonoBehaviour
{

    public static bool isPlayingCampaign;

    public void LoadByIndex(int levelChoice)
    {
        LoadOnEnter.nextLevel = 0;
        ScoreDisplay.score = 0;
        ScoreDisplay.backgroundScore = 0;
        SceneManager.LoadScene(levelChoice);
    }

    public void CampaignTrue()
    {
        isPlayingCampaign = true;
    }

    public void CampaignFalse()
    {
        isPlayingCampaign = false;
    }
}
