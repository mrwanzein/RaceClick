using UnityEngine;

public class CameraMovementLv2 : MonoBehaviour {

    public Transform raceSet;
    public Transform BG;

	
	// Update is called once per frame
	void Update () {

        switch (raceSet.childCount)
        {
            case 46:
                transform.position = Vector3.Lerp(transform.position, new Vector3(46, 9, transform.position.z), 0.1f);
                BG.position = Vector3.Lerp(BG.position, new Vector3(46, 9, BG.position.z), 0.1f);
                break;
            case 39:
                transform.position = Vector3.Lerp(transform.position, new Vector3(46, 28, transform.position.z), 0.1f);
                BG.position = Vector3.Lerp(BG.position, new Vector3(46, 28, BG.position.z), 0.1f);
                break;
            case 20:
                transform.position = Vector3.Lerp(transform.position, new Vector3(77, 28, transform.position.z), 0.1f);
                BG.position = Vector3.Lerp(BG.position, new Vector3(77, 28, BG.position.z), 0.1f);
                break;
            case 0:
                if (LoadSceneOnClickForMainMenu.isPlayingCampaign)
                {
                    if (PlayerPrefs.GetInt("Level2Unlocked") != 2)
                    {
                        PlayerPrefs.SetInt("Level2Unlocked", 2);
                    }
                }
                break;
        }

    }
}
