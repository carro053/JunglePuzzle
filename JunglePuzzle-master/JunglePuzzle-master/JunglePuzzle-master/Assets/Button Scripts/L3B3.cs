using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L3B3 : MonoBehaviour
{
    public bool isactive;
    public L3B4 bs;
    public L3B5 bs1;
    public GameObject obj;
    public GameObject button;
    public Material mat1;
    int count;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        isactive = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(isactive && bs.isactive)
        {
            bs1.ison = true;
            button.GetComponent<MeshRenderer>().material = mat1;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        isactive = true;
        if (count < 1)
        {
            Instantiate(obj, new Vector3(43,7,0), Quaternion.identity);
            count++;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        isactive = false;
    }
}
