using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class controls : MonoBehaviour
{
    public GameObject player;
    public float speed = 0.01f;


    void Start()
    {
        
    }

    
    void Update()
    {
        Vector3 movement = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            movement += new Vector3(0, 0, speed);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            movement -= new Vector3(0, 0, speed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            movement -= new Vector3(speed, 0, 0);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            movement += new Vector3(speed, 0, 0);
        }
        
        if (Input.GetKey(KeyCode.LeftControl))
        {
            movement -= new Vector3(0, speed/2, 0);
        }
        else if (Input.GetKey(KeyCode.Space))
        {
            movement += new Vector3(0, speed/2, 0);
        }


        player.transform.position += movement * Time.deltaTime;

    }
}
