using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DanceParty : MonoBehaviour
{
    private Animator anim;
    

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
       
    }

    // Update is called once per frame
    void Update()
    {
        //anim.SetInteger("IdleSelect", 0);

        if (Input.GetKey(KeyCode.Q))
        {
            anim.SetTrigger("Dance_01");
        }
        else if (Input.GetKey(KeyCode.W))
        {
            anim.SetTrigger("Dance_02");
        }
        else if (Input.GetKey(KeyCode.E))
        {
            anim.SetTrigger("Dance_03");
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            anim.SetTrigger("Dance_04");
        }
        else if (Input.GetKeyDown(KeyCode.T))
        {
            anim.SetTrigger("Dance_05");
        }
        else if(Input.GetKeyDown(KeyCode.Y))
        {
            anim.SetTrigger("Dance_06");
        }
        else
        {
            //anim.SetInteger("IdleSelect", Random.Range(1, 4));
        }
    }
}
