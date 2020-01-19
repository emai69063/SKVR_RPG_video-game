using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectSpawns : MonoBehaviour
{
    public Vector3 spawnValues;
    public GameObject m_object;
    public GameObject m_object1;
    public GameObject m_object2;
    int randEnemy;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 2; i++)
        {
            spawnObjects();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    void spawnObjects()
    {
        Vector3 pos = new Vector3(Random.Range(-2.0F, 2.0F), 0, Random.Range(-2.0F, 2.0F));
        Instantiate(m_object, pos + pos, Quaternion.identity);

        Vector3 pos1 = new Vector3(Random.Range(-2.0F, 2.0F), 0, Random.Range(-2.0F, 2.0F));
        Instantiate(m_object1, pos1 + pos1, Quaternion.identity);

        Vector3 pos2 = new Vector3(Random.Range(-2.0F, 2.0F), 0, Random.Range(-2.0F, 2.0F));
        Instantiate(m_object2, pos2 + pos2, Quaternion.identity);


    }
}
