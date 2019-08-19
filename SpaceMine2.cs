using UnityEngine;
using UnityEngine.UI;

public class SpaceMine2 : MonoBehaviour
{
    Animator forAnim;
    public GameObject raceSet;
    public GameObject ScoreIndicator;
    public GameObject MineExplode;
    public GameObject MineDisarmed;
    bool clickableOnce;
    public static bool clickedSpaceMine2;

    // Use this for initialization
    void Start()
    {

        forAnim = GetComponent<Animator>();
        clickableOnce = true;
        clickedSpaceMine2 = false;

    }

    // Update is called once per frame
    void Update()
    {
        MiddleClickedTarget();
        ComboClickedTarget();
    }

    void MiddleClickedTarget()
    {
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

        if (Input.GetMouseButtonDown(2))
        {
            if (hit.collider != null)
            {
                if (hit.collider.tag == "SpaceMine2" && clickableOnce == true)
                {
                    clickableOnce = false;
                    clickedSpaceMine2 = true;
                    forAnim.Play("SpaceMineExplode2");
                    MineExplode.GetComponent<AudioSource>().Play();
                    ScoreIndicator.GetComponent<Text>().text = "-300";
                    ScoreIndicator.GetComponent<Animator>().Play("ScoreLost");
                    ScoreDisplay.score -= 300;
                    ScoreDisplay.backgroundScore -= 300;
                    SavingHighScore.scoreForHighScore -= 300;
                    Destroy(GameObject.Find("SpaceMineTut"));
                }
            }
        }
    }

    void ComboClickedTarget()
    {
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

        if (Input.GetMouseButtonDown(1) && Input.GetMouseButtonDown(0))
        {
            if (hit.collider != null)
            {
                if (hit.collider.tag == "SpaceMine2" && clickableOnce == true)
                {
                    clickableOnce = false;
                    clickedSpaceMine2 = true;
                    forAnim.Play("SpaceMineDeactivate2");
                    MineDisarmed.GetComponent<AudioSource>().Play();
                    ScoreIndicator.GetComponent<Text>().text = "+300";
                    ScoreIndicator.GetComponent<Animator>().Play("ScoreGained");
                    ScoreDisplay.score += 300;
                    ScoreDisplay.backgroundScore += 300;
                    SavingHighScore.scoreForHighScore += 300;
                    Destroy(GameObject.Find("SpaceMineTut"));
                }
            }
        }
    }

    void DestroyObjectEvent()
    {
        Destroy(gameObject);
        if (raceSet.transform.childCount > 1)
        {
            raceSet.transform.GetChild(1).gameObject.SetActive(true);
        }
    }
}

