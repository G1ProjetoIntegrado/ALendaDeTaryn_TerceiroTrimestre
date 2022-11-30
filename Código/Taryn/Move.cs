using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
  public float Speed;
  Animator anim;

  void Start()
  {
    anim = GetComponent<Animator>();
  }

  void Update()
  {
    Movemento();
  }
  void Movemento()
  {
    Vector3 Movimento = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
    transform.position += Movimento * Time.deltaTime * Speed;

    if(Input.GetAxis("Horizontal")>0f) 
    {
      anim.SetBool("Walk",true); 
    }
    if(Input.GetAxis("Horizontal")<0f) 
    {
      anim.SetBool("Walk", true);
    }
    if(Input.GetAxis("Horizontal") == 0f) 
    {
      anim.SetBool("Walk", false);
    }
        
    float inputAxis = Input.GetAxis("Horizontal");
    if(inputAxis > 0)
    {
      transform.eulerAngles = new Vector2(0f, 0f);
    }
    if(inputAxis < 0)
    {
      transform.eulerAngles = new Vector2(0f, 180f);
    }
  }
  
}
