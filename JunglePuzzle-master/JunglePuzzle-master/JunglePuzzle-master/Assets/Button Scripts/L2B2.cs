using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L2B2 : MonoBehaviour
{
    public bool isActive;
    public int boxCount;
    public L2B1 bs;
    public GameObject obj;
    public GameObject button;
    public Material mat1;
    public L2B3 bs1;

    // Start is called before the first frame update
    void Start()
    {
        isActive = false;
        boxCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(isActive && bs.isActive)
        {
            button.GetComponent<MeshRenderer>().material = mat1;
            bs1.isOn = true;
        }
      
    }

    void OnCollisionEnter(Collision collision)
    {
        isActive = true;
        if (boxCount < 3)
        {
            Instantiate(obj, new Vector3(148, 41, 0), Quaternion.identity);
            boxCount++;
        }
            
    }
    void OnCollisionExit(Collision collision)
    {
        isActive = false;
    }
}
