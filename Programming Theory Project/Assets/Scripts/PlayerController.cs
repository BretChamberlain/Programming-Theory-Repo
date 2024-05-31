using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRB;
    private float playerSpeed = 10.0f;
    private float xMove = 0.0f;
    private float zMove = 0.0f;
    

    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        PlayerMovement();
        playerRB.velocity = Vector3.ClampMagnitude(playerRB.velocity, playerSpeed);
    }


    private void PlayerMovement()
    {
        xMove = Input.GetAxisRaw("Horizontal") * playerSpeed * Time.deltaTime;
        zMove = Input.GetAxisRaw("Vertical") * playerSpeed * Time.deltaTime;

        
        playerRB.AddForce(xMove, 0, zMove, ForceMode.Impulse);

        if (xMove == 0.0f)
        {
            playerRB.velocity = new Vector3(0, 0, playerRB.velocity.z);
        }
        
        if (zMove == 0.0f)
        {
            playerRB.velocity = new Vector3(playerRB.velocity.x, 0, 0);
        }

        
    }
}
