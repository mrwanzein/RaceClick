using UnityEngine;

public class CameraMovementLv6 : MonoBehaviour
{
    public Transform raceSet;
    public Transform BG;
    public Transform constelation;

    // Update is called once per frame
    void Update()
    {

        switch (raceSet.childCount)
        {
            case 79:
                transform.position = Vector3.Lerp(transform.position, new Vector3(48, 9, transform.position.z), 0.1f);
                BG.position = Vector3.Lerp(BG.position, new Vector3(48, 9, BG.position.z), 0.1f);
                break;
            case 48:
                transform.position = Vector3.Lerp(transform.position, new Vector3(77, 9, transform.position.z), 0.1f);
                BG.position = Vector3.Lerp(BG.position, new Vector3(77, 9, BG.position.z), 0.1f);
                constelation.position = Vector3.Lerp(constelation.position, new Vector3(50, constelation.position.y, constelation.position.z), 0.1f);
                break;
            case 15:
                transform.position = Vector3.Lerp(transform.position, new Vector3(107, 9, transform.position.z), 0.1f);
                BG.position = Vector3.Lerp(BG.position, new Vector3(107, 9, BG.position.z), 0.1f);
                constelation.position = Vector3.Lerp(constelation.position, new Vector3(80, constelation.position.y, constelation.position.z), 0.1f);
                break;
            case 0:
                if (LoadSceneOnClickForMainMenu.isPlayingCampaign)
                {
                    if (PlayerPrefs.GetInt("Level6Unlocked") != 6)
                    {
                        PlayerPrefs.SetInt("Level6Unlocked", 6);
                    }
                }
                break;
        }

    }
}
