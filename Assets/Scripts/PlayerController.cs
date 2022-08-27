using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Player Movement Handlers")]
    public float playerForwardMoveSpeed = 5f;
    public float playerSidewardsMoveSpeed = 3f;
    public float playerIncreaseSpeed = 1f;
    public float playerJumpSpeed = 5f;

    private float targetSpeed = 100f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        MovePlayerForward();

        ChangePlayerSides();

        PlayerJump();
    }

    void MovePlayerForward()
    {
        //TURN IT ON LATER!
/*        if (playerForwardMoveSpeed < targetSpeed)
        {
            playerForwardMoveSpeed += playerIncreaseSpeed * Time.deltaTime;
        }*/

        transform.Translate(Vector3.forward * playerForwardMoveSpeed * Time.deltaTime);
    }

    void ChangePlayerSides()
    {
        float horizontalInput = Input.GetAxis("Horizontal") * playerSidewardsMoveSpeed * Time.deltaTime;
        transform.Translate(Vector3.right * horizontalInput);
    }

    void PlayerJump()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(new Vector3(0f, playerJumpSpeed, 0f), ForceMode.Impulse);
        }
    }

    //WallCollision

}
