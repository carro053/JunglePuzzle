using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Character : MonoBehaviour
{
    public float speed;
    public float jumpHeight;
    private Vector3 direction;
    private Rigidbody rb;
    public LayerMask ground;
    public Transform feet;
    private int db = 0;
    public GameObject obj;
    public int buttoncount;
    public int buttoncount1;
    bool levelComplete;


     // Start is called before the first frame update
    void Start()
    {
        speed = 3.0f;
        jumpHeight = 6.5f;
        rb = GetComponent<Rigidbody>();
        buttoncount=0;
        buttoncount1=0;
 
    }

    // Update is called once per frame
    void Update()
    {
      
        direction = Vector3.zero;
        direction.x = Input.GetAxis("Horizontal");
        direction = direction.normalized;
        if (direction != Vector3.zero)
        {
            transform.forward = direction;
            rb.MovePosition(transform.position + (direction * speed * Time.deltaTime));
        }
        bool grounded()
        {
            if (Physics.CheckSphere(feet.position, .1f, ground))
            {
                db = 0;
                return true;
            }
            else { return false; }
        }
        if(Input.GetButtonDown("Jump")&& (grounded() || db < 2))
        {
            SoundManager.PlaySound("Jump");
            db += 1;
            rb.AddForce(Vector3.up * jumpHeight, ForceMode.VelocityChange);
        }


    }

    

void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Enemy" || collision.gameObject.tag == "Enemy")
        {
            SoundManager.PlaySound("EnemyHit");
            transform.position = new Vector3(-8.06f, -2.36f, 0f);
            rb.velocity = Vector3.zero;
        }
        else if (collision.gameObject.name == "Button" && buttoncount < 1)
        {
            
            Instantiate(obj, new Vector3(59, 1, 0), Quaternion.identity); buttoncount++;
        }
        else if (collision.gameObject.name == "Button2" && buttoncount < 3)
        {
            Instantiate(obj, new Vector3(59, 1, 0), Quaternion.identity); buttoncount++;
        }
        else if (collision.gameObject.name == "Button1" && buttoncount1 < 1)
        {
            Instantiate(obj, new Vector3(67, 1, 0), Quaternion.identity);
            buttoncount1++;

        }
        else if (collision.gameObject.name == "Exit")
        {
            SceneManager.LoadScene("MainMenu");
        }

    }

}
