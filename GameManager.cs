using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public GameObject Ready;
    public GameObject Set;
    public GameObject Go;
    public AudioSource[] sounds;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Ready.SetActive(true);
        sounds[1].PlayDelayed(0.75f);
        StartCoroutine(SetTimer());
        StartCoroutine(GoTimer());
        StartCoroutine(EnableMouse());

    }

    private void Update()
    {
        if (sounds[0].time > sounds[0].clip.length - 0.05f)
        {
            sounds[0].Play();
        }
    }


    IEnumerator SetTimer()
    {
        yield return new WaitForSeconds(2);
        Set.SetActive(true);
        sounds[1].PlayDelayed(0.9f);

    }

    IEnumerator GoTimer()
    {
        yield return new WaitForSeconds(3);
        Go.SetActive(true);
        sounds[2].PlayDelayed(1.1f);
    }

    IEnumerator EnableMouse()
    {
        yield return new WaitForSeconds(4.25f);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        sounds[0].Play();
    }

}
