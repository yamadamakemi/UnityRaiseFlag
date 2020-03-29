using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestAnimationScript : MonoBehaviour
{
    public Animator Ani;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("up"))
        {
            print("up arrow key is held down");
            Ani.SetBool("isHand", true);

            Invoke("Reset", 0.3f);
        }
    }

    private void Reset()
    {
        print("reset");
        Ani.SetBool("isHand", false);
    }
}
