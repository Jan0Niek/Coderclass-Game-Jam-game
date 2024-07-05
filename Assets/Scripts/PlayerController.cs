using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
<<<<<<< Updated upstream
    [SerializeField]
    Vector3 moveForce = new Vector3(5, 0, 5);
    [SerializeField]
    float jumpForce = 5f;
    public float score = 0f;
=======
    [SerializeField] private Vector3 moveForce = new Vector3(5, 0, 5);
    [SerializeField] private float jumpForce = 5f;
    [SerializeField] private float strength;

>>>>>>> Stashed changes
    Rigidbody rb;
    bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Vector3 move = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
            move += transform.forward;
        if (Input.GetKey(KeyCode.S))
            move -= transform.forward;
        if (Input.GetKey(KeyCode.A))
            move -= transform.right;
        if (Input.GetKey(KeyCode.D))
            move += transform.right;

        move = move.normalized * moveForce.z * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + move);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Ground"))
        {
            isGrounded = true;
        }
        else if (collision.collider.CompareTag("BEACHBALL"))
        {
            Vector3 awayFromPlayer = (collision.gameObject.transform.position - transform.position);
            collision.gameObject.GetComponent<Rigidbody>().AddForce(awayFromPlayer * strength, ForceMode.Impulse);
        }
    }
}
