using UnityEngine;
using System.Collections;

public class jump : MonoBehaviour
{

    public Vector3 jumph;
    public float jumpForce = 2.0f;

    public bool isGrounded;
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        jumph = new Vector3(0.0f, 2.0f, 0.0f);
    }

    void OnCollisionStay()
    {
        isGrounded = true;
    }
    void OnCollisionExit()
    {
        isGrounded = false;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {

            rb.AddForce(jumph * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
    }
}