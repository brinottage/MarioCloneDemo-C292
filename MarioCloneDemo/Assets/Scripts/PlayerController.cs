using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] float moveSpeed; // SF allows to edit stuff from inside the editor
    [SerializeField] float jumpForce;

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // our rb is the rigidbody the object is attached to
    }

    // Update is called once per frame
    void Update()
    {
        
        // Called when a particular key is put down
        if (Input.GetKeyDown(KeyCode.Space)) {
            Jump();
        }

        Move();

    }

    private void Move()
    {

        // Takes input axis 'Horizontal'. Left/A is -1, Right/D is 1
        float moveInput = Input.GetAxis("Horizontal");

        // moveInput decides direction, moveSpeed decides speed, the Vector is (1, 0)
        transform.Translate(moveInput * Vector2.right * moveSpeed * Time.deltaTime);

    }

    private void Jump()
    {

        // Jump functionality
          // AddForce adds physics force in a direction according to the Vector
          // Vector2.up = Vector2(0,1)
          // ForceMode2D.Impulse appleis full force
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse); 

    }

}
