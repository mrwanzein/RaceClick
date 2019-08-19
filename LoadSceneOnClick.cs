using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadSceneOnClick : MonoBehaviour {

    bool isPaused;
    bool canPause;
    static int trackingScoreIncaseOfRestart;
    TimerDisplay time;
    GameObject raceSet;

    public GameObject pauseMenu;
    public GameObject pauseMenuCaveat;

    void Start()
    {
        isPaused = false;
        canPause = false;
        time = GameObject.Find("Timer").GetComponent<TimerDisplay>();
        raceSet = GameObject.Find("raceSet");
        trackingScoreIncaseOfRestart = ScoreDisplay.score;
    }

    void Update()
    {
        StartCoroutine(TimeBeforePauseIsEnabled());

        if (canPause)
        {
            CanPause();
        }

        SpaceMineClickedWhilePaused();

        SpaceMine1ClickedWhilePaused();

        SpaceMin2ClickedWhilePaused();
    }


    IEnumerator TimeBeforePauseIsEnabled()
    {
        yield return new WaitForSeconds(4.25f);

        canPause = true;

    }

    void CanPause() {

        if (Input.GetKeyDown(KeyCode.P) || Input.GetKeyDown(KeyCode.Escape))
        {
            if (!isPaused)
            {

                Time.timeScale = 0;
                time.enabled = false;
                raceSet.SetActive(false);
                pauseMenu.SetActive(true);
                isPaused = true;

            }
            else
            {

                if (pauseMenuCaveat.activeSelf)
                {
                    pauseMenuCaveat.SetActive(false);
                }

                Time.timeScale = 1;
                time.enabled = true;
                raceSet.SetActive(true);
                pauseMenu.SetActive(false);
                isPaused = false;
            }
        }

    }

    public void LoadByIndex(int levelChoice)
    {
        LoadOnEnter.nextLevel = 0;
        ScoreDisplay.score = 0;
        ScoreDisplay.backgroundScore = 0;
        SceneManager.LoadScene(levelChoice);
    }

    public void RestartCurrentLevel()
    {
        ScoreDisplay.score = trackingScoreIncaseOfRestart;
        ScoreDisplay.backgroundScore = trackingScoreIncaseOfRestart;
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }

    public void ResumeTime()
    {
        Time.timeScale = 1;
    }

    void SpaceMineClickedWhilePaused()
    {
        if (Time.timeScale == 0 && SpaceMine.clickedSpaceMine == true)
        {
            Destroy(raceSet.transform.GetChild(0).gameObject);
            raceSet.transform.GetChild(1).gameObject.SetActive(true);
            SpaceMine.clickedSpaceMine = false;
        }
    }

    void SpaceMine1ClickedWhilePaused()
    {
        if (Time.timeScale == 0 && SpaceMine1.clickedSpaceMine1 == true)
        {
            Destroy(raceSet.transform.GetChild(0).gameObject);
            raceSet.transform.GetChild(1).gameObject.SetActive(true);
            SpaceMine1.clickedSpaceMine1 = false;
        }
    }

    void SpaceMin2ClickedWhilePaused()
    {
        if (Time.timeScale == 0 && SpaceMine2.clickedSpaceMine2 == true)
        {
            Destroy(raceSet.transform.GetChild(0).gameObject);
            raceSet.transform.GetChild(1).gameObject.SetActive(true);
            SpaceMine2.clickedSpaceMine2 = false;
        }
    }
}
