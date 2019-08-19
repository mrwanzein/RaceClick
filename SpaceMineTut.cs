using System.Collections;
using UnityEngine;

public class SpaceMineTut : MonoBehaviour {


	// Use this for initialization
	void Start () {

        StartCoroutine(ShowTut());

	}
	
	// Update is called once per frame
	void Update () {

        

	}

    IEnumerator ShowTut()
    {
        yield return new WaitForSeconds(3.9f);
        GetComponent<CanvasGroup>().alpha = 1;
    }

}
