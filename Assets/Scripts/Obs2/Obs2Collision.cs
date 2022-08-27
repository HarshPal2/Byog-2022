using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obs2Collision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(GetComponentInParent<Transform>().localRotation);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            transform.localRotation = Quaternion.Euler(new Vector3(-80, -90, 0));
            GetComponent<MeshCollider>().enabled = false;
        }
    }
}
