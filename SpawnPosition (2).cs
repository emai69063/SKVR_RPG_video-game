using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPosition : MonoBehaviour {
    public Vector3 spawnValues;
    public GameObject enemies;
    int randEnemy;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            spawnEnemies();
        }
    }

    // Update is called once per frame
    void Update()   
    {
       
    }

    void spawnEnemies() {
        Vector3 pos = new Vector3(Random.Range(-2.0F, 2.0F), 0, Random.Range(-2.0F, 2.0F));
        Instantiate(enemies, pos + pos, Quaternion.identity);
        

    }
}
