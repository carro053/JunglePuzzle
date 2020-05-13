using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L3B4 : MonoBehaviour
{
    public bool isactive;
    // Start is called before the first frame update
    void Start()
    {
        isactive = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        isactive = true;
    }
}
