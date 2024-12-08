using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ElmaToplama : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Elma"))
        {
            SkorManager.Instance.UpdateElmaSayisi(1);
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
