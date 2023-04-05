using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wine_Destroyer : MonoBehaviour
{
    public float topBorder = 32.0f;
    public float lowerBorder = -15.0f;
    void Start()
    {
        
    }

    void Update()
    {
        if (transform.position.z > topBorder)
        {
            Destroy(gameObject);
        }else if(transform.position.z < lowerBorder)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}