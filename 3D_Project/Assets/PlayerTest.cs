using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTest : MonoBehaviour
{
    public Rigidbody rb;
    public bool bottonDown;





    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        ButtonDown();
        if (bottonDown)
        {
            rb.AddForce(new Vector3(1,1,1) * 500f, ForceMode.Impulse);
        }
    }

    private bool ButtonDown()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            Debug.Log("I pressed Z botton");
            return bottonDown = true;
        }
        return bottonDown = false;
    }









}
