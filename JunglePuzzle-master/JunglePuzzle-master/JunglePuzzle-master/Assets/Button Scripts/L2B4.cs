using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L2B4 : MonoBehaviour
{
    public bool isOn;
    public GameObject obj;
    public L2B5 bs;
    public bool isActive;
    public GameObject obj1;
    public int count;
    // Start is called before the first frame update
    void Start()
    {
        isActive = false;
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(bs.isActive && isActive && count<1)
        {
            Instantiate(obj1, new Vector3(180.25f, 28.21f, 0), Quaternion.identity);
            count++;
        }
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if (isOn)
        {
            Instantiate(obj, new Vector3(182, 32, 0), Quaternion.identity);
            isActive = true;
        }
    }
    void OnCollisionExit(Collision collision)
    {
        isActive = false; 
    }
}
