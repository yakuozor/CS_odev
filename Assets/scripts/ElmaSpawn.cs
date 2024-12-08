using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElmaSpawn : MonoBehaviour
{
    public Transform Player;
    public GameObject ElmaPrefab;

    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            SpawnApple();
        }
    }


    void SpawnApple()
    {

        Instantiate(ElmaPrefab, Player.position, Quaternion.identity);

    }
}
