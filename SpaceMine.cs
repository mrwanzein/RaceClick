using UnityEngine;
using UnityEngine.UI;

public class SpaceMine : MonoBehaviour {

    Animator forAnim;
    public GameObject raceSet;
    public GameObject ScoreIndicator;
    public GameObject MineExplode;
    public GameObject MineDisarmed;
    bool clickableOnce;
    public static bool clickedSpaceMine;

    // Use this for initialization
    void Start () {

        forAnim = GetComponent<Animator>();
        clickableOnce = true;
        clickedSpaceMine = false;

    }
	
	// Update is called once per frame
	void Update () {
        LeftClickedTarget();
        RightClickedTarget();
        MiddleClickedTarget();
    }

    void LeftClickedTarget()
    {
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

        if (Input.GetMouseButtonDown(0))
        {
            if (hit.collider != null)
            {
                if (hit.collider.tag == "SpaceMine" && clickableOnce == true)
                {
                    clickableOnce = false;
                    clickedSpaceMine = true;
                    forAnim.Play("SpaceMineExplode");
                    MineExplode.GetComponent<AudioSource>().Play();
                    ScoreIndicator.GetComponent<Text>().text = "-200";
                    ScoreIndicator.GetComponent<Animator>().Play("ScoreLost");
                    ScoreDisplay.score -= 200;
                    ScoreDisplay.backgroundScore -= 200;
                    SavingHighScore.scoreForHighScore -= 200;
                    Destroy(GameObject.Find("SpaceMineTut"));
                }
            }
        }

    }

    void RightClickedTarget()
    {
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

        if (Input.GetMouseButtonDown(1))
        {
            if (hit.collider != null)
            {
                if (hit.collider.tag == "SpaceMine" && clickableOnce == true)
                {
                    clickableOnce = false;
                    clickedSpaceMine = true;
                    forAnim.Play("SpaceMineDeactivate");
                    MineDisarmed.GetComponent<AudioSource>().Play();
                    ScoreIndicator.GetComponent<Text>().text = "+200";
                    ScoreIndicator.GetComponent<Animator>().Play("ScoreGained");
                    ScoreDisplay.score += 200;
                    ScoreDisplay.backgroundScore += 200;
                    SavingHighScore.scoreForHighScore += 200;
                    Destroy(GameObject.Find("SpaceMineTut"));
                }
            }
        }
    }

    void MiddleClickedTarget()
    {
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

        if (Input.GetMouseButtonDown(2))
        {
            if (hit.collider != null)
            {
                if (hit.collider.tag == "SpaceMine" && clickableOnce == true)
                {
                    clickableOnce = false;
                    clickedSpaceMine = true;
                    forAnim.Play("SpaceMineExplode");
                    MineExplode.GetComponent<AudioSource>().Play();
                    ScoreIndicator.GetComponent<Text>().text = "-200";
                    ScoreIndicator.GetComponent<Animator>().Play("ScoreLost");
                    ScoreDisplay.score -= 200;
                    ScoreDisplay.backgroundScore -= 200;
                    SavingHighScore.scoreForHighScore -= 200;
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
