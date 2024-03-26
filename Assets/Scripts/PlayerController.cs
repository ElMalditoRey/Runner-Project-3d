using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Base Vars")]
    public float speed = 10f;

    [Header("Jump Vars")]
    public float jumpForce = 50f;
    public Vector3 jump;
    public bool isGrounded;

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
        myRB = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 2.0f, 0.0f);
    }

    void OnCollisionStay()
    {
        isGrounded = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {

            myRB.AddForce(jump * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput) * speed;

        myRB.MovePosition(myRB.position + movement * Time.fixedDeltaTime);
    }
}
