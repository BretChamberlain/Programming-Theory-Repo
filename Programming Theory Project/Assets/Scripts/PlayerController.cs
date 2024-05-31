using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRB;
    private float playerSpeed = 9.0f;
    private float moveX, moveZ = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        PlayerMovement();
    }

    private void PlayerMovement()
    {
        moveX = Input.GetAxis("Horizontal");
        moveZ = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * moveX * playerSpeed * Time.deltaTime);
        transform.Translate(Vector3.forward * moveZ * playerSpeed * Time.deltaTime);
    }
}
