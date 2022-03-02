using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject pipePrefab;
    float randomHeight = 0.7f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawnpipes", 2.0f, 3.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawnpipes()
    {
        Instantiate(pipePrefab, new Vector2(2, Random.Range(-randomHeight, randomHeight)), Quaternion.identity);
    }
}
