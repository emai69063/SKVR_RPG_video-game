using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Global;

public class PCont : MonoBehaviour
{
    private Rigidbody rb;
    private float playerSpd = 10.0f;
    private Vector3 pMoveVector;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Vector3 pMoveVector = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {

    }


    void FixedUpdate()
    {
        //Debug.Log(Mathf.Sin(Global.theta));
        rb.velocity = transform.right * Input.GetAxis("Horizontal") * playerSpd + transform.forward * Input.GetAxis("Vertical") * playerSpd;
        pMoveVector.Set(rb.velocity.x, 0, rb.velocity.z); //movement
        rb.velocity = pMoveVector;//movement


        //transform.position += transform.right * Input.GetAxis("Horizontal") * playerSpd + transform.forward * Input.GetAxis("Vertical") * playerSpd;
    }
}
