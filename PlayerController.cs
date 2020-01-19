using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private Rigidbody rb;
    private float playerSpd = 5.0f;
    private Vector3 pMoveVector;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Vector3 pMoveVector = new Vector3(0,0,0);
    }

    // Update is called once per frame
    void Update()
    {

    }


    void FixedUpdate()
    {
        pMoveVector.Set(Input.GetAxis("Horizontal")*playerSpd, 0, Input.GetAxis("Vertical"));
        rb.velocity = pMoveVector;
        Debug.Log(Input.GetAxis("Horizontal"));
   
        

    }
}
