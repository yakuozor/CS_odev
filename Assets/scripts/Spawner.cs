using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject SepetPrefab;
    public Transform[] spawnPoint;
    public float spawnTime = 2f;
    private float timer;

    private GameObject currentSepet;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnTime)
        {
            SpawnSepet();
            timer = 0;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnSepet();
        }
    }

    void SpawnSepet()
    {
        if (currentSepet != null)
        {
            Destroy(currentSepet);
        }

        int index = Random.Range(0, spawnPoint.Length);
        currentSepet = Instantiate(SepetPrefab, spawnPoint[index].position, Quaternion.identity);
    }

}
