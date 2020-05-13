using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L3B10 : MonoBehaviour
{
    public GameObject obj;
    int count;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (count < 1)
        {
            Instantiate(obj, new Vector3(51.5f, 22, 0), Quaternion.identity);
            count++;
        }
    }
}
