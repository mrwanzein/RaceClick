using UnityEngine;

public class CameraMovementLv3 : MonoBehaviour {

    public Transform raceSet;
    public Transform BG;

	
	// Update is called once per frame
	void Update () {

        switch (raceSet.childCount)
        {
            case 74:
                transform.position = Vector3.Lerp(transform.position, new Vector3(16, 27, transform.position.z), 0.1f);
                BG.position = Vector3.Lerp(BG.position, new Vector3(16, 27, BG.position.z), 0.1f);
                break;
            case 47:
                transform.position = Vector3.Lerp(transform.position, new Vector3(47, 27, transform.position.z), 0.1f);
                BG.position = Vector3.Lerp(BG.position, new Vector3(47, 27, BG.position.z), 0.1f);
                break;
            case 17:
                transform.position = Vector3.Lerp(transform.position, new Vector3(78, 27, transform.position.z), 0.1f);
                BG.position = Vector3.Lerp(BG.position, new Vector3(78, 27, BG.position.z), 0.1f);
                break;
            case 0:
                if (LoadSceneOnClickForMainMenu.isPlayingCampaign)
                {
                    if (PlayerPrefs.GetInt("Level3Unlocked") != 3)
                    {
                        PlayerPrefs.SetInt("Level3Unlocked", 3);
                    }
                }
                break;
        }

    }
}
