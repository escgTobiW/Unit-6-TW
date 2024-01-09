using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class ANIMATE : MonoBehaviour
{


    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKey("w")) || (Input.GetKey("a")) || (Input.GetKey("s")) || (Input.GetKey("d")))
        {
            anim.SetBool("run", true);
            //anim.SetBool("fall", false);
        }
        else
        {
            anim.SetBool("run", false);

        }


        if (Input.GetButton("Jump"))
        {
            anim.SetBool("jump", true);
        }
        else
        {
            anim.SetBool("jump", false);

        }


        if (Input.GetKey("q"))
        {
            anim.SetBool("fall", true);
        }
        else
        {
            anim.SetBool("fall", false);

        }
    }
}
