using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float ForceJump;
    private Rigidbody2D rig;
    public bool isJumping;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump") && isJumping == true)
        {
            rig.AddForce(new Vector2(0f, ForceJump), ForceMode2D.Impulse);
            anim.SetBool("Jump",true); 
            isJumping = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "is Jumping")
        {
            isJumping = true;
            anim.SetBool("Jump",false); 
        }
    }
}
