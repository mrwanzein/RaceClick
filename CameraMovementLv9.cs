using UnityEngine;

public class CameraMovementLv9 : MonoBehaviour
{
    public Transform raceSet;
    public Transform BG;

    // Update is called once per frame
    void Update()
    {

        switch (raceSet.childCount)
        {
            case 65:
                transform.position = Vector3.Lerp(transform.position, new Vector3(16, 27, transform.position.z), 0.1f);
                BG.position = Vector3.Lerp(BG.position, new Vector3(16, 27, BG.position.z), 0.1f);
                break;
            case 40:
                transform.position = Vector3.Lerp(transform.position, new Vector3(16, 45, transform.position.z), 0.1f);
                BG.position = Vector3.Lerp(BG.position, new Vector3(16, 45, BG.position.z), 0.1f);
                break;
            case 15:
                transform.position = Vector3.Lerp(transform.position, new Vector3(16, 63, transform.position.z), 0.1f);
                BG.position = Vector3.Lerp(BG.position, new Vector3(16, 63, BG.position.z), 0.1f);
                break;
            case 0:
                if (LoadSceneOnClickForMainMenu.isPlayingCampaign)
                {
                    if (PlayerPrefs.GetInt("Level9Unlocked") != 9)
                    {
                        PlayerPrefs.SetInt("Level9Unlocked", 9);
                    }
                }
                break;
        }
    }
}
