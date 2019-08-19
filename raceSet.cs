using System.Collections;
using UnityEngine;

public class raceSet : MonoBehaviour {

    public ParticleSystem explosionFx;


    // Use this for initialization
    void Start () {

        for (int i = 1; i < transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.SetActive(false);

        }

    }
	
	// Update is called once per frame
	void Update () {

        if (transform.childCount == 0)
        {
            GameObject.Find("Timer").GetComponent<TimerDisplay>().enabled = false;
            explosionFx.gameObject.SetActive(true);
        }

        if (GameObject.Find("Bonus sprite piece"))
        {
            StartCoroutine(DestroyPieces1());
        }

    }

    IEnumerator DestroyPieces1()
    {
        yield return new WaitForSeconds(1);

          Destroy(GameObject.Find("Bonus sprite piece"));
       
    }
}

