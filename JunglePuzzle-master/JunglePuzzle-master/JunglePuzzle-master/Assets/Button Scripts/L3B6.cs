using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L3B6 : MonoBehaviour
{
    public GameObject obj;
    public bool isActive;
    public int count;
    public L3B7 bs;
    public L3B8 bs1;
    public L3B9 bs2;
    public Material mat1;
    public GameObject button;
    public GameObject button1;
    // Start is called before the first frame update
    void Start()
    {
        isActive = false;
        count = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isActive && bs.isactive && bs1.isactive)
        {
            bs2.ison = true;
            button1.GetComponent<MeshRenderer>().material = mat1;
        }
        else if(isActive && bs.isactive)
        {
            bs1.ison = true;
            button.GetComponent<MeshRenderer>().material = mat1;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        isActive = true;
        if (count < 2)
        {
            Instantiate(obj, new Vector3(46, 18, 0), Quaternion.identity);
            count++;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        isActive = false;
    }
}
