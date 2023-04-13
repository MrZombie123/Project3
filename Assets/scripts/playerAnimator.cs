using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAnimator : MonoBehaviour
{
    //[SerializeField]private GameObject player;
    [SerializeField]private Animator animator;
//    public bool isTurning;
    public float intAnimations;
    private bool isGrounded;
    private float xAxis;
    [SerializeField]private float zAxis;
    [SerializeField]private float mouseAxis;
    public CharacterController controller;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = controller.isGrounded;
        xAxis= Input.GetAxis("Horizontal");
        zAxis= Input.GetAxis("Vertical");
        mouseAxis= Input.GetAxis("Mouse X");
        if(isGrounded==false && gameObject.GetComponent<playerHealth>().ded==false)
        {
            animator.SetBool("isturning",false);
            animator.SetBool("isgrounded", false);
        }
         else
        {
            animator.SetBool("isgrounded", true);
        }
        if(gameObject.GetComponent<playerHealth>().ded==true)
        {
            animator.SetBool("DED", true);
        }
        else
        {
             animator.SetBool("DED", false);
        }
        
        switch (intAnimations)
        {
            
        
        case float n when zAxis >= .1:
         
            animator.SetInteger("action",1);
            animator.SetBool("isturning",false);
         break;
         
         case float n when zAxis <= -.1:
         
            animator.SetInteger("action",2);
            animator.SetBool("isturning",false);
         
          break;

        case float n when mouseAxis != 0:
            animator.SetBool("isturning",true);
        break;

         default:
         animator.SetInteger("action",0);
        animator.SetBool("isturning",false);
        break;
        }
    }
}
