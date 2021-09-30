using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isRunning : MonoBehaviour
{
    private Animator ani;

    void Start()
    {
    ani = GetComponent<Animator>();
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
        {
            ani.SetBool("isRunning", true);
        }
        else
        {
            ani.SetBool("isRunning", false);
        }

        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            ani.SetTrigger("jump");
        }
        
    }
}
