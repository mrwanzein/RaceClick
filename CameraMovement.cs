using UnityEngine;

public class CameraMovement : MonoBehaviour {

    public Transform raceSet;
    public Transform BG;
    public Transform constelation;

    // Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

        switch (raceSet.childCount)
        {
            case 65:
                transform.position = Vector3.Lerp(transform.position, new Vector3(16, 27, transform.position.z), 0.1f);
                BG.position = Vector3.Lerp(BG.position, new Vector3(16, 27, BG.position.z), 0.1f);
                break;
            case 40:
                transform.position = Vector3.Lerp(transform.position, new Vector3(48, 27, transform.position.z), 0.1f);
                BG.position = Vector3.Lerp(BG.position, new Vector3(48, 27, BG.position.z), 0.1f);
                break;
            case 9:
                transform.position = Vector3.Lerp(transform.position, new Vector3(48, 9, transform.position.z), 0.1f);
                BG.position = Vector3.Lerp(BG.position, new Vector3(48, 9, BG.position.z), 0.1f);
                constelation.position = Vector3.Lerp(constelation.position, new Vector3(constelation.position.x, -13, constelation.position.z), 0.1f);
                break;
        }
    }

}
