using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obs2Fail : MonoBehaviour
{
    private PlayerController playerController;

    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            if(playerController.playerForwardMoveSpeed > 80f)
            {
                KillPlayer();
            }

            else
            {
                Invoke(nameof(KillPlayer), 0.1f);
            }
        }
    }

    void KillPlayer()
    {
        playerController.playerForwardMoveSpeed = 0f;
        playerController.playerSidewardsMoveSpeed = 0f;
        playerController.playerJumpSpeed = 0f;
        GameObject.Find("Player").GetComponent<BoxCollider>().enabled = false;
        Destroy(gameObject);
    }
}
