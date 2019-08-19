using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmergencyEnableGameObject : MonoBehaviour
{

    public GameObject bgProp;

    // Start is called before the first frame update
    void Start()
    {
        bgProp.SetActive(true);
    }

    
}
