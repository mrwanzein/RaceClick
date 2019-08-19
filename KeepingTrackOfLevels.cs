using UnityEngine;
using UnityEngine.UI;

public class KeepingTrackOfLevels : MonoBehaviour
{


    public GameObject level2;
    public GameObject level3;
    public GameObject level4;
    public GameObject level5;
    public GameObject level6;
    public GameObject level7;
    public GameObject level8;
    public GameObject level9;
    public GameObject level10;


    void Start()
    {
        if (PlayerPrefs.GetInt("Level2Unlocked") == 2)
        {
            level2.GetComponent<Button>().interactable = true;
        }

        if (PlayerPrefs.GetInt("Level3Unlocked") == 3)
        {
            level3.GetComponent<Button>().interactable = true;
        }

        if (PlayerPrefs.GetInt("Level4Unlocked") == 4)
        {
            level4.GetComponent<Button>().interactable = true;
        }

        if (PlayerPrefs.GetInt("Level5Unlocked") == 5)
        {
            level5.GetComponent<Button>().interactable = true;
        }

        if (PlayerPrefs.GetInt("Level6Unlocked") == 6)
        {
            level6.GetComponent<Button>().interactable = true;
        }

        if (PlayerPrefs.GetInt("Level7Unlocked") == 7)
        {
            level7.GetComponent<Button>().interactable = true;
        }

        if (PlayerPrefs.GetInt("Level8Unlocked") == 8)
        {
            level8.GetComponent<Button>().interactable = true;
        }

        if (PlayerPrefs.GetInt("Level9Unlocked") == 9)
        {
            level9.GetComponent<Button>().interactable = true;
        }

        if (PlayerPrefs.GetInt("Level10Unlocked") == 10)
        {
            level10.GetComponent<Button>().interactable = true;
        }
    }


}
