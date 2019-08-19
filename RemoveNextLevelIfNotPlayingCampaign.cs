using UnityEngine;

public class RemoveNextLevelIfNotPlayingCampaign : MonoBehaviour
{

    public GameObject nextLevelButton;

    // Start is called before the first frame update
    void Start()
    {
        if (!LoadSceneOnClickForMainMenu.isPlayingCampaign)
        {
            nextLevelButton.SetActive(false);
        }
    }
}
