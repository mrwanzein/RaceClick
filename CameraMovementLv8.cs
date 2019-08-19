using UnityEngine;

public class CameraMovementLv8 : MonoBehaviour
{
    public Transform raceSet;
    public Transform BG;

    // Update is called once per frame
    void Update()
    {

        switch (raceSet.childCount)
        {
            case 72:
                transform.position = Vector3.Lerp(transform.position, new Vector3(48, 9, transform.position.z), 0.1f);
                BG.position = Vector3.Lerp(BG.position, new Vector3(48, 9, BG.position.z), 0.1f);
                break;
            case 46:
                transform.position = Vector3.Lerp(transform.position, new Vector3(48, 27, transform.position.z), 0.1f);
                BG.position = Vector3.Lerp(BG.position, new Vector3(48, 27, BG.position.z), 0.1f);
                break;
            case 21:
                transform.position = Vector3.Lerp(transform.position, new Vector3(48, 45, transform.position.z), 0.1f);
                BG.position = Vector3.Lerp(BG.position, new Vector3(48, 45, BG.position.z), 0.1f);
                break;
            case 0:
                if (LoadSceneOnClickForMainMenu.isPlayingCampaign)
                {
                    if (PlayerPrefs.GetInt("Level8Unlocked") != 8)
                    {
                        PlayerPrefs.SetInt("Level8Unlocked", 8);
                    }
                }
                break;
        }
    }
}
