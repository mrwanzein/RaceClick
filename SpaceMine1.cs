using UnityEngine;
using UnityEngine.UI;

public class SpaceMine1 : MonoBehaviour
{
    Animator forAnim;
    bool clickableOnce;

    public GameObject raceSet;
    public GameObject ScoreIndicator;
    public GameObject MineExplode;
    public GameObject MineDisarmed;
    public static bool clickedSpaceMine1;

    // Use this for initialization
    void Start () {

        forAnim = GetComponent<Animator>();
        clickableOnce = true;
        clickedSpaceMine1 = false;

    }
	
	// Update is called once per frame
	void Update () {
        LeftClickedTarget();
        MiddleClickedTarget();
        RightClickedTarget();
    }

    void LeftClickedTarget()
    {
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

        if (Input.GetMouseButtonDown(0))
        {
            if (hit.collider != null)
            {
                if (hit.collider.tag == "SpaceMine1" && clickableOnce == true)
                {
                    clickableOnce = false;
                    clickedSpaceMine1 = true;
                    forAnim.Play("SpaceMineExplode1");
                    MineExplode.GetComponent<AudioSource>().Play();
                    ScoreIndicator.GetComponent<Text>().text = "-250";
                    ScoreIndicator.GetComponent<Animator>().Play("ScoreLost");
                    ScoreDisplay.score -= 250;
                    ScoreDisplay.backgroundScore -= 250;
                    SavingHighScore.scoreForHighScore -= 250;
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
                if (hit.collider.tag == "SpaceMine1" && clickableOnce == true)
                {
                    clickableOnce = false;
                    clickedSpaceMine1 = true;
                    forAnim.Play("SpaceMineDeactivate1");
                    MineDisarmed.GetComponent<AudioSource>().Play();
                    ScoreIndicator.GetComponent<Text>().text = "+250";
                    ScoreIndicator.GetComponent<Animator>().Play("ScoreGained");
                    ScoreDisplay.score += 250;
                    ScoreDisplay.backgroundScore += 250;
                    SavingHighScore.scoreForHighScore += 250;
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
                if (hit.collider.tag == "SpaceMine1" && clickableOnce == true)
                {
                    clickableOnce = false;
                    clickedSpaceMine1 = true;
                    forAnim.Play("SpaceMineExplode1");
                    MineExplode.GetComponent<AudioSource>().Play();
                    ScoreIndicator.GetComponent<Text>().text = "-250";
                    ScoreIndicator.GetComponent<Animator>().Play("ScoreLost");
                    ScoreDisplay.score -= 250;
                    ScoreDisplay.backgroundScore -= 250;
                    SavingHighScore.scoreForHighScore -= 250;
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
