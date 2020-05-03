using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L2B5 : MonoBehaviour
{
    public bool isOn;
    public bool isActive;
    // Start is called before the first frame update
    void Start()
    {
        isActive = false;   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if (isOn)
            isActive = true;
    }
    void OnCollisionExit(Collision collision)
    {
        isActive = false;
    }
}
