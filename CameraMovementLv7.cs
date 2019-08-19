using UnityEngine;

public class CameraMovementLv7 : MonoBehaviour
{
    public Transform raceSet;
    public Transform BG;

    // Update is called once per frame
    void Update()
    {

        switch (raceSet.childCount)
        {
            case 79:
                transform.position = Vector3.Lerp(transform.position, new Vector3(16, 27, transform.position.z), 0.1f);
                BG.position = Vector3.Lerp(BG.position, new Vector3(16, 27, BG.position.z), 0.1f);
                break;
            case 41:
                transform.position = Vector3.Lerp(transform.position, new Vector3(46, 27, transform.position.z), 0.1f);
                BG.position = Vector3.Lerp(BG.position, new Vector3(46, 27, BG.position.z), 0.1f);
                break;
            case 8:
                transform.position = Vector3.Lerp(transform.position, new Vector3(46, 9, transform.position.z), 0.1f);
                BG.position = Vector3.Lerp(BG.position, new Vector3(46, 9, BG.position.z), 0.1f);
                break;
            case 0:
                if (LoadSceneOnClickForMainMenu.isPlayingCampaign)
                {
                    if (PlayerPrefs.GetInt("Level7Unlocked") != 7)
                    {
                        PlayerPrefs.SetInt("Level7Unlocked", 7);
                    }
                }
                break;
        }
    }
}
