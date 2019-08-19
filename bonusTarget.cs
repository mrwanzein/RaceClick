using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bonusTarget : MonoBehaviour {

    private Explodable _explodable;
    public GameObject ScoreIndicator;
    public GameObject sounds;

    // Use this for initialization
    void Start () {

        _explodable = GetComponent<Explodable>();

    }
	
	// Update is called once per frame
	void Update () {


    }

    void OnMouseDown()
    {
        _explodable.explode();
        ExplosionForce ef = GameObject.FindObjectOfType<ExplosionForce>();
        ef.doExplosion(transform.position);

        sounds.GetComponent<AudioSource>().Play();

        ScoreIndicator.GetComponent<Text>().text = "+ 500";
        ScoreIndicator.GetComponent<Animator>().Play("ScoreGained");
        ScoreDisplay.score += 500;
        ScoreDisplay.backgroundScore += 500;
        SavingHighScore.scoreForHighScore += 500;

    }

    void Destroy()
    {
        Destroy(gameObject);
    }

}
