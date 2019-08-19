using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SoundFadeIn : MonoBehaviour {

    [SerializeField]
    private int m_FadeInTime = 8;

    private void Start()
    {
        AudioListener.volume = 0;
    }


    private void Update()
    {
        if (AudioListener.volume < 0.3f)
        {
            AudioListener.volume = AudioListener.volume + (Time.deltaTime / (m_FadeInTime + 1));
        }
        else
        {
            Destroy(this);
        }
    }
}
