using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static PCont;


public class Global
{
    public static float theta = 0;
}


public class CamController : MonoBehaviour
{

    private float xRotateAngle = 0;
    private float yRotateAngle = 0;
    private float rotateMult = 10;
    public bool menuMode = false;
    public bool cCheck = false;
    public bool cBool = false;


    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(menuMode);
        xRotateAngle += Input.GetAxis("Mouse X");
        yRotateAngle += Input.GetAxis("Mouse Y");
        cBool = Cursor.visible;
        //Global.theta = xRotateAngle / (2.5*rotateMult);

        Debug.Log(cBool);


        if (menuMode == false)
        {
            transform.rotation = Quaternion.Euler(-yRotateAngle * rotateMult, xRotateAngle * rotateMult, 0); //Rotating camera
        }
        if (Input.GetKeyDown(KeyCode.Escape) && cCheck == false) //Check for Button holding but no seizuring
        {
            cCheck = true;

            if (menuMode == false) //Checking for menu (Pressing esc)
            {
                Cursor.visible = true;
                menuMode = true;
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.lockState = CursorLockMode.None;
            }
            else if (menuMode != false)
            {
                Cursor.visible = false;
                menuMode = false;
                //Debug.Log("Menu byebye");
            }
        }
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            cCheck = false;
        }

        //if (menuMode == true)
        //{
            //Cursor.lockState = CursorLockMode.Locked;
            //Cursor.lockState = CursorLockMode.None;
            //Debug.Log("Lockstate");
        //}
    }

    private void FixedUpdate()
    {
        

    }
}

