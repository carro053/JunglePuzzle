using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L3B9 : MonoBehaviour
{
    public bool ison;
    public GameObject obj;
    public bool isactive;
    // Start is called before the first frame update
    void Start()
    {
        ison = false;
        isactive = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        isactive = true;
        if (ison)
        {
            isactive = true;
            Instantiate(obj, new Vector3(38,18,0),Quaternion.identity);
        }
    }
}
