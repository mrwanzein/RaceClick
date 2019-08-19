using UnityEngine;

public class CameraMovementLv4 : MonoBehaviour
{
    public Transform raceSet;
    public Transform BG;

    // Update is called once per frame
    void Update()
    {

        switch (raceSet.childCount)
        {
            case 59:
                transform.position = Vector3.Lerp(transform.position, new Vector3(16, 27, transform.position.z), 0.1f);
                BG.position = Vector3.Lerp(BG.position, new Vector3(16, 27, BG.position.z), 0.1f);
                break;
            case 40:
                transform.position = Vector3.Lerp(transform.position, new Vector3(46, 27, transform.position.z), 0.1f);
                BG.position = Vector3.Lerp(BG.position, new Vector3(46, 27, BG.position.z), 0.1f);
                break;
            case 25:
                transform.position = Vector3.Lerp(transform.position, new Vector3(48, 9, transform.position.z), 0.1f);
                BG.position = Vector3.Lerp(BG.position, new Vector3(48, 9, BG.position.z), 0.1f);
                break;
            case 0:
                if (LoadSceneOnClickForMainMenu.isPlayingCampaign)
                {
                    if (PlayerPrefs.GetInt("Level4Unlocked") != 4)
                    {
                        PlayerPrefs.SetInt("Level4Unlocked", 4);
                    }
                }
                break;
        }
    }
}
