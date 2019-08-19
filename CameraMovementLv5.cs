using UnityEngine;

public class CameraMovementLv5 : MonoBehaviour
{
    public Transform raceSet;
    public Transform BG;

    // Update is called once per frame
    void Update()
    {

        switch (raceSet.childCount)
        {
            case 87:
                transform.position = Vector3.Lerp(transform.position, new Vector3(48, 9, transform.position.z), 0.1f);
                BG.position = Vector3.Lerp(BG.position, new Vector3(48, 9, BG.position.z), 0.1f);
                break;
            case 52:
                transform.position = Vector3.Lerp(transform.position, new Vector3(48, 27, transform.position.z), 0.1f);
                BG.position = Vector3.Lerp(BG.position, new Vector3(48, 27, BG.position.z), 0.1f);
                break;
            case 16:
                transform.position = Vector3.Lerp(transform.position, new Vector3(48, 45, transform.position.z), 0.1f);
                BG.position = Vector3.Lerp(BG.position, new Vector3(48, 45, BG.position.z), 0.1f);
                break;
            case 0:
                if (LoadSceneOnClickForMainMenu.isPlayingCampaign)
                {
                    if (PlayerPrefs.GetInt("Level5Unlocked") != 5)
                    {
                        PlayerPrefs.SetInt("Level5Unlocked", 5);
                    }
                }
                break;
        }

    }
}
