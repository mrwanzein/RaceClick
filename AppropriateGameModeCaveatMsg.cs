using UnityEngine;
using UnityEngine.UI;

public class AppropriateGameModeCaveatMsg : MonoBehaviour
{

    public Text recapCaveat;
    public Text pauseMenuCaveat;

    // Start is called before the first frame update
    void Start()
    {
        if (!LoadSceneOnClickForMainMenu.isPlayingCampaign)
        {
            recapCaveat.text = "Are you sure?";
            recapCaveat.fontSize = 125;
            recapCaveat.rectTransform.offsetMax = new Vector2(recapCaveat.rectTransform.offsetMax.x, -200);

            pauseMenuCaveat.text = "Are you sure?";
            pauseMenuCaveat.fontSize = 125;
            pauseMenuCaveat.rectTransform.offsetMax = new Vector2(recapCaveat.rectTransform.offsetMax.x, -200);
        }
    }

}
