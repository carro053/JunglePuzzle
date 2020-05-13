using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L3B8 : MonoBehaviour
{
    public bool isactive;
    public bool ison;
    // Start is called before the first frame update
    void Start()
    {
        isactive = false;
        ison = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (ison)
        {
            isactive = true;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        isactive = false;
    }
}
