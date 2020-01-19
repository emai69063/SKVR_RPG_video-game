using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    public Camera fpsCam;
    public float damage = 10f;
    // Start is called before the first frame update
    void Start()
    {

    }

// Update is called once per frame
void Update()
{

    if (Input.GetButtonDown("Fire1")){
        Shoot();
    }
}
    
    void Shoot()
    {
        Enemy enemy = new Enemy();
        RaycastHit hitInfo;
        if (Physics.Raycast(fpsCam.transform.position,fpsCam.transform.forward, out hitInfo)){

            Debug.Log(hitInfo.transform.name);


            enemy = hitInfo.transform.GetComponent<Enemy>();
            if (enemy != null) {
                enemy.TakeDamage(damage);
            }
        }
    }


}


