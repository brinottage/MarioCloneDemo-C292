using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPlatform : MonoBehaviour
{

    private bool move = false;
    [SerializeField] float speed;
    private float startLocation;
    private float endLocation;

    [SerializeField] float distance;
    private Vector3 direction = Vector3.up;

    // Start is called before the first frame update
    void Start()
    {
        startLocation = transform.position.y;

        endLocation = transform.position.y + distance;
    }

    // Update is called once per frame
    void Update()
    {
        if (move) {
            MovePlatform();
        }
    }

    void OnCollisionEnter2D(Collision2D collision){

        // Checks to see of the GO it collided with is the Player
        // Activates move boolean
        if (collision.gameObject.tag == "Player") {
            move = true;
        }
    }

    void MovePlatform(){

            transform.Translate(direction * speed * Time.deltaTime);

            if (transform.position.y >= endLocation){
                 direction = Vector3.down;
            } else if (transform.position.y <= startLocation){
                 direction = Vector3.up;
            }
    }
}
