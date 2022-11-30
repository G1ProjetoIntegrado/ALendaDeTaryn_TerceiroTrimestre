using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class Hades : MonoBehaviour
{
    private Transform pointA;
    private Transform pointB;
    public float speed;
    Animator anim;
    public bool A = false;
    public bool B = true;
    public int damageEnimes;

    void Start()
    {
        pointA = GameObject.FindGameObjectWithTag("point A").transform; 
        pointB = GameObject.FindGameObjectWithTag("point B").transform;
        anim = GetComponent<Animator>(); 
    }

    
    void Update()
    {
        if(A == true)
        {
            transform.position = Vector3.MoveTowards(transform.position,pointA.position, speed*Time.deltaTime);
            anim.SetBool("Run", true);
        }
        if (transform.position == pointA.position)
        {
            transform.eulerAngles = new Vector2(0f, 0f);
            anim.SetBool("Run", false);
            anim.SetBool("Slap", true);
            A = true;
            B = false;
        }
        else
        {
            anim.SetBool("Slap", false);
            anim.SetBool("Ground", false);
        }
        
        if(B == true)
        {
            transform.position = Vector3.MoveTowards(transform.position,pointB.position, speed*Time.deltaTime);
            anim.SetBool("Run", true);
        }
        if (transform.position == pointB.position)
        {
            transform.eulerAngles = new Vector2(0f, 180f);
            anim.SetBool("Run", false);
            anim.SetBool("Ground", true);
        }
    }    
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<Life>().Dano(damageEnimes);
        }
    }
}
