using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnThunder : MonoBehaviour
{
    public GameObject[] Thunder; //variavel que armazena os raios, que serao para spawnar 
    public Transform[] placeSpawn; //pontos de spawn
    //Array é uma variavel que armazena diversas valores do mesmo tipo, ao mesmo tempo
    //Array é representada por []
    public float timeMaxSpawn;
    public float timeSpawn; //tempo atual do spawn

    // Start is called before the first frame update
    void Start()
    {
        timeSpawn = timeMaxSpawn;
    }

    // Update is called once per frame
    void Update()
    {
        timeSpawn -= Time.deltaTime; 
        if(timeSpawn <= 0)
        {
            Spawn();
        }
    }

    private void Spawn()
    {
        int oi = Random.Range(0, Thunder.Length);
        int place = Random.Range(0, placeSpawn.Length); //ponto aleatorio

        Instantiate(Thunder[oi], placeSpawn[place].position, Quaternion.Euler(0f, 0f, 0f));
        timeSpawn = timeMaxSpawn;
    }
}