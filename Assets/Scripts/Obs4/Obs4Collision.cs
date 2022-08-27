using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obs4Collision : MonoBehaviour
{
    public GameObject[] arrowPrefabs;
    bool hasCollided = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hasCollided)
        {
            foreach (var arrow in arrowPrefabs)
            {
                float movespeed = Random.Range(1, 30);
                arrow.transform.localPosition += new Vector3(0f, movespeed * Time.deltaTime, movespeed * 2.34f * Time.deltaTime); 
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            hasCollided = true;
        }
    }
}
