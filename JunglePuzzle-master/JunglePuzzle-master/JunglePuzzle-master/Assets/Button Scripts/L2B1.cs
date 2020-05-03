using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L2B1 : MonoBehaviour
{
    public bool isActive;
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
        isActive = true;
    }
    void OnCollisionExit(Collision collision)
    {
        isActive = false;
    }
}
