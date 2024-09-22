using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    // we need to access the Animator component 
    // from animator component we can get the parameters to set its value 
    // once we get parameters we can control animations on a button press 
    // W for forward and space for jump 

    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        if (animator == null)
        {
            setDefaultAnimState();
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        if (animator != null)
        {
            bool isWPressed = Input.GetKey(KeyCode.W);
            bool isSpacePressed = Input.GetKey(KeyCode.Space);
            if (isWPressed)
            {
                animator.SetBool("IsWalk", true);
            }
            if (!isWPressed) { 
                animator.SetBool("IsWalk", false); 
            }
            if (isSpacePressed) {
                animator.SetBool("IsJump", true);
            }

            if (!isSpacePressed)
            {
                animator.SetBool("IsJump", false);
            }
        }
    }

    public void setDefaultAnimState()
    {
        animator.SetBool("IsWalk", false);
        animator.SetBool("IsJump", false);
    }
}
