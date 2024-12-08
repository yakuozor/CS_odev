using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zemin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Elma"))
        {
            SkorManager.Instance.UpdateCan(1);
            Destroy(other.gameObject);           
        }
    }
}
