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
    public Vector3 respawnPoint;
    public bool doubleJump;


     // Start is called before the first frame update
    void Start()
    {
       
        rb = GetComponent<Rigidbody>();
        buttoncount=0;
        buttoncount1=0;
        doubleJump = false;
        if (SceneManager.GetActiveScene().name == "Level1")
        {
            respawnPoint = new Vector3(-14.0f, -3.5f, 0);
            speed = 3.0f;
            jumpHeight = 6.2f;
            doubleJump = false;
        }
        else if(SceneManager.GetActiveScene().name == "Level2")
        {
            respawnPoint = new Vector3(-9, -2, 0);
            speed = 5.0f;
            jumpHeight = 7.0f;
            doubleJump = true;
        }
        else if (SceneManager.GetActiveScene().name == "Level3")
        {
            respawnPoint = new Vector3(-14, -3, 0);
            speed = 5.0f;
            jumpHeight = 7.0f;
            doubleJump = true;
        }

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
        if (Input.GetButtonDown("Jump") && grounded())
        {
            db += 1;
            rb.AddForce(Vector3.up * jumpHeight, ForceMode.VelocityChange);
        }
        else if (Input.GetButtonDown("Jump") && doubleJump == true && db < 2)
        {
            db += 1;
            float x = rb.velocity.x;
            rb.velocity = new Vector3(x, 0, 0);
            rb.AddForce(Vector3.up * jumpHeight, ForceMode.VelocityChange);

        }


    }

    

void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            transform.position = respawnPoint;
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
        else if (collision.gameObject.name == "ExitLevel1")
        {
            SceneManager.LoadScene("Level2");

        }
        else if (collision.gameObject.name == "ExitLevel2")
        {
            SceneManager.LoadScene("Level3");

        }

    }

}
