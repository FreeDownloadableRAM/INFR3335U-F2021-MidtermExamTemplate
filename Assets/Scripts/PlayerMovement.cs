using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//To be able to go into end scene

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;
    private float moveSpeed;
    //private float jumpForce; we arent jumping in this game
    private float dirX, dirZ, dirY;


    // Start is called before the first frame update
    void Start()
    {
        //set values
        moveSpeed = 3f;
        //jumpForce = 50f;
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        //Arrow key controls
        //dirX = Input.GetAxis("Horizontal") * (moveSpeed * Time.deltaTime);
        //dirZ = Input.GetAxis("Vertical") * (moveSpeed * Time.deltaTime);
        dirZ = Input.GetAxis("Horizontal") * moveSpeed;
        dirX = Input.GetAxis("Vertical") * moveSpeed;


        /*
        if (Input.GetKeyDown("space"))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
        */

        //if escape key is hit, go to main menu, and from there they can quit the game
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Start");
        }


    }

    private void FixedUpdate()
    {
        //velocity update
        rb.velocity = new Vector3(dirX, rb.velocity.y, -dirZ);

    }

    //enemy collision, go to gameover screen

    void OnCollisionEnter(Collision col)
    {
        // When target is hit
        if (col.gameObject.tag == "Enemy")
        {
            SceneManager.LoadScene("End");
        }
    }

}
