using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Base Vars")]
    public float speed = 10f;

    [Header("Jump Vars")]
    public float jumpForce = 40f;
    public bool canJump;
    public bool jumped;

    Rigidbody myRB;
    public Camera myCam;
    public float camLock; //maxlook up/down

    Vector3 myLook;

    void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        myLook = transform.localEulerAngles;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
