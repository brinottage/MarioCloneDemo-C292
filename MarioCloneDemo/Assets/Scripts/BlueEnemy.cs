using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueEnemy : MonoBehaviour
{
    [SerializeField] float moveSpeed; // SF allows to edit stuff from inside the editor
  
    private float startLocation;
    private float endLocation;

    [SerializeField] float distance;
    private Vector3 direction = Vector3.left;

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // our rb is the rigidbody the object is attached to

        startLocation = transform.position.x;

        endLocation = transform.position.x - distance;
    }

    // Update is called once per frame
    void Update()
    {
        

        Move();

    }

    private void Move()
    {

        // Endlessly moves left
        //transform.Translate(-1 * Vector2.right * moveSpeed * Time.deltaTime);

        // Moves enemy back and forth
       transform.Translate(direction * moveSpeed * Time.deltaTime);

       if (transform.position.x <= endLocation){
            direction = Vector3.right;
       } else if (transform.position.x >= startLocation){
            direction = Vector3.left;
       }
    }

}
