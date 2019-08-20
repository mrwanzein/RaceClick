using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Explodable))]
public class ExplodeOnClick : MonoBehaviour {

	private Explodable _explodable;
    private GameObject raceSet;

    public GameObject sounds;
    public GameObject finish;
    public GameObject BgVfx; 
    public ParticleSystem explosionFx;
    public ParticleSystem backgroundVfx;

	void Start()
	{
		_explodable = GetComponent<Explodable>();
        raceSet = GameObject.Find("raceSet");
	}

    void Update()
    {
        StartCoroutine(DestroyPieces());
    }

    IEnumerator DestroyPieces()
    {
        yield return new WaitForSeconds(0.5f);

        if (GameObject.Find("Target piece"))
        {
            Destroy(GameObject.Find("Target piece"));
        }
    }

    void OnMouseDown()
    {
        // Exploding force
        _explodable.explode();
        ExplosionForce ef = GameObject.FindObjectOfType<ExplosionForce>();
        ef.doExplosion(transform.position);

        // Particle and background effects
        if (explosionFx == true)
        {
            explosionFx.transform.position = transform.position;
            explosionFx.Play();
        }
        else
        {

        }
        
        if (backgroundVfx == true)
        {
            backgroundVfx.gameObject.SetActive(true);
        }
        else
        {
            
        }

        if(BgVfx == true)
        {
            BgVfx.SetActive(true);
        }
        else
        {

        }

        //OnClick Sound
        sounds.GetComponent<AudioSource>().Play();

        // Displaying next target
        if (raceSet.transform.childCount > 1)
        {
            raceSet.transform.GetChild(1).gameObject.SetActive(true);
        }

        if (raceSet.transform.childCount == 1)
        {
            finish.SetActive(true);
        }


        // Reference for Score display
        ScoreDisplay.score += 50;
        ScoreDisplay.backgroundScore += 50;
        SavingHighScore.scoreForHighScore += 50;

    }

    void DestroyObjectIfMissed()
    {
        Destroy(gameObject);
        if (raceSet.transform.childCount > 1)
        {
            raceSet.transform.GetChild(1).gameObject.SetActive(true);
        }
    }
}
