using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class TimerDisplay : MonoBehaviour {

    float KeepingTrackOfLevels;

    public static float timerOnPlay;
    public Text timer;

	// Use this for initialization
	void Start () {
        timer.text = "0 m 0 s";
        timerOnPlay = 0;
	}
	
	// Update is called once per frame
	void Update () {

        StartCoroutine(Chrono());

    }

    IEnumerator Chrono()
    {
        yield return new WaitForSeconds(4.25f);

        timerOnPlay += Time.deltaTime;

        float minutes = Mathf.Floor(timerOnPlay / 60);
        float seconds = (timerOnPlay % 60);
        timer.text = minutes.ToString("0") + " m " + seconds.ToString("0") + " s";
        
    }
}
