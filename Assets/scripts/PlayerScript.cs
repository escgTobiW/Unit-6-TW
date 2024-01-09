using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerScript : MonoBehaviour
{

    public int speed = 4;
    public float jump;


    Animator anim;


    public float jumpSpeed = 8.0f;
    Vector3 moveDirection = Vector3.zero;

    Rigidbody2D rb;
    Helping Helping;

    void Start()
    {
        anim = GetComponent<Animator>();

        rb = GetComponent<Rigidbody2D>();
        Helping = gameObject.AddComponent<Helping>();


    }

  
    void Update()
    {
        float movementDirectionY = moveDirection.y;

        if (Input.GetKeyDown("space") /* && (Helping.GroundCheck(0, 0))*/ == true)
        {
            //anim.SetBool("jump", true);
            //rb.AddForce(new Vector3(0, jump, 0), ForceMode.Impulse);
            moveDirection.y = jumpSpeed;

        }







        if ((Input.GetKey("w")) || (Input.GetKey("a")) || (Input.GetKey("s")) || (Input.GetKey("d")))
        {

            anim.SetBool("run", true);

            if (Input.GetKey("w"))
            {
                transform.position += transform.forward * speed * Time.deltaTime;
            }

            if (Input.GetKey("a"))
            {
                transform.Rotate(0, -0.2f, 0);
            }

            if (Input.GetKey("s"))
            {
                transform.position -= transform.forward * speed * Time.deltaTime;

            }

            if (Input.GetKey("d"))
            {
                transform.Rotate(0, 0.2f, 0);
            }

        }
        else
        {
            anim.SetBool("run", false);
        }



    }
}
