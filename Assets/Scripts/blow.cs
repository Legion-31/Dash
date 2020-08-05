
//using UnityEngine;
//
//public class blow : MonoBehaviour
//{
//    // Start is called before the first frame update
//    public Rigidbody rb;
//    public float ForwardForce = 2000f;
//    public float upForce = 2000f;
//
//    // Update is called once per frame
//    void FixedUpdate()
//    {
//        if(Input.GetKey("w"))
//        {
//            //rb.AddForce(0, upForce * Time.deltaTime, ForwardForce * Time.deltaTime,ForceMode.Impulse);
//            rb.AddExplosionForce(100, transform.position, 1, 1);
//        }
//    }
//}
using UnityEngine;
using System.Collections;
using UnityEngine.Tilemaps;
//using System.Numerics;

public class blow : MonoBehaviour
{

    public Vector3 jumph;
    public Vector3 roth;
    public float jumpForce = 2.0f;

    public bool isGrounded;
    public Rigidbody rb;
    public TimeManager tm;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        jumph = new Vector3(0f, 1f, 10.0f);
        roth = new Vector3(6.0f, 5.0f, 12.0f);
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
        if (Input.GetKeyDown(KeyCode.W) && isGrounded)
        {

            rb.AddForce(jumph * jumpForce, ForceMode.Impulse);
            rb.AddRelativeTorque(roth * jumpForce,ForceMode.Acceleration);
            //rb.AddForceAtPosition(jumph * jumpForce, jumph);
            //tm.DoSlowmotion();
            
            
            isGrounded = false;
            
        }
        if (Input.GetKey(KeyCode.W))
        {
            Time.timeScale = 0.5f;
        }
        else
            Time.timeScale = 1;

    }
}