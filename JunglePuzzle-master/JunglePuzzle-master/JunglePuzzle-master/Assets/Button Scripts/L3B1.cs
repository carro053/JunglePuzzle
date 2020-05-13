using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L3B1 : MonoBehaviour
{
    public int count;
    public GameObject obj;
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
            Instantiate(obj, new Vector3(3, 4, 0), Quaternion.identity);
            count++;
        }
    }
}
