using UnityEngine;

public class MusicSliderVolumeChange : MonoBehaviour {

    private AudioSource audioSrc;
    private float musicVol = 0.3f;

	// Use this for initialization
	void Start () {
        audioSrc = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        audioSrc.volume = musicVol;
	}

    public void SetMusicVol(float vol)
    {
        musicVol = vol;
    }

    public void SetMasterVol(float vol)
    {
        AudioListener.volume = vol;
    }
}
