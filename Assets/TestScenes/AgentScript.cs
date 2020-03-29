﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentScript : MonoBehaviour
{
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)) {
            Debug.Log("right");
            anim.SetTrigger("isRight");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("left");
            anim.SetTrigger("isLeft");
        }
    }
}
