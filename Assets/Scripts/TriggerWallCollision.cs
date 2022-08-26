using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerWallCollision : MonoBehaviour
{
    private WallCollision wallCollider;

    private void Start()
    {
        wallCollider = GetComponentInParent<WallCollision>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            wallCollider.checkCollision();
        }
    }
}
