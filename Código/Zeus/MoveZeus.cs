using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveZeus : MonoBehaviour
{
  public bool power = false;
  private Transform player;
  public float speed;
  Animator anim;
  private Rigidbody2D rig;
  public int damage;

  void Start()
  {
    player = GameObject.FindGameObjectWithTag("Player").transform; 
    anim = GetComponent<Animator>();
    rig = GetComponent<Rigidbody2D>();
  }

  void Update()
  {
    Move();
  }

  void Move()
  {
    transform.position = Vector3.MoveTowards(transform.position,player.position, speed*Time.deltaTime);
  }

//Código de repulso Taryn
  // private void OnCollisionEnter2D(Collision2D collision) //Componente de colisão na unity
  // {
  //   if(collision.gameObject.tag == "Player") //Se Zeus collidir com Taryn
  //   Debug.Log("aee");
  //   {
  //     rig.AddForce(new Vector2(7f, 0), ForceMode2D.Impulse); //Impulso
  //   }
  // }
}