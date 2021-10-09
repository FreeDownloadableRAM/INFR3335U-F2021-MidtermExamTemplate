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

    //rotation
    //private float rotx, roty, rotz, rotw;

    // Start is called before the first frame update
    void Start()
    {
        //set values
        moveSpeed = 3f;
        //jumpForce = 50f;
        rb = GetComponent<Rigidbody>();
        //rotx = 0;
        //roty = 0;
        //rotz = 0;
        //rotw = 0;

        //transform.rotation = new Quaternion(rotx, roty, rotz, rotw);
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
        //transform.Rotate(rotx, roty, rotz);, y was 1st attempt
        //4 directions for movement, set rotation angle for each key pressed

        if (Input.GetKeyDown(KeyCode.UpArrow)) //Face away from camera
        {
            //roty = 91;
            transform.rotation = Quaternion.Euler(0, 90, 0);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow)) //Face toward the camera
        {
            //roty = 1;
            transform.rotation = Quaternion.Euler(0, 270, 0);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow)) //Face to the right
        {
            //roty = 179;
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow)) //Face to the left
        {
            //roty = 1;
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }

        //update rotation
        //transform.rotation = new Quaternion(rotx, roty, rotz, rotw);
        //transform.Rotate(rotx, roty, rotz);

    }

    private void FixedUpdate()
    {
        //velocity update
        rb.velocity = new Vector3(dirX, rb.velocity.y, -dirZ);

        //reset to face forward
        //roty = 0;
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
