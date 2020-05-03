using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L2B3 : MonoBehaviour
{
    public bool isOn;
    public bool isActive;
    public L2B2 bs;
    public Material mat1;
    public GameObject button;
    public GameObject button1;
    public L2B4 bs1;
    public L2B5 bs2;



    // Start is called before the first frame update
    void Start()
    {
        isOn = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isActive && bs.isActive)
        {
            bs1.isOn = true;
            bs2.isOn = true;
            button.GetComponent<MeshRenderer>().material = mat1;
            button1.GetComponent<MeshRenderer>().material = mat1;

        }
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if (isOn)
        {
            bs1.isOn = true;
            bs2.isOn = true;
            isActive = true;
        }
    }
    void OnCollisionExit(Collision collision)
    {
        isActive = false;   
    }

}
