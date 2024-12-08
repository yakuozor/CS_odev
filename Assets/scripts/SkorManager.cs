using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SkorManager : MonoBehaviour
{
    public static SkorManager Instance; 

    public TMP_Text text; 
    public TMP_Text textcan; 
    public int elmaSayisi = 0;
    public int Can = 15;
    public GameObject textyandýn;
    public GameObject player;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void Update()
    {
        if(Can == 0)
        {
            player.SetActive(false);
            textyandýn.SetActive(true);

        }
    }
    public void UpdateElmaSayisi(int miktar)
    {
        elmaSayisi += miktar;
        text.SetText("Elma Sayisi: " + elmaSayisi);
    }
    public void UpdateCan(int miktar)
    {
        Can -= miktar;
        textcan.SetText("Can: " + Can);
    }
}
