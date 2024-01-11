using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyProjectile : MonoBehaviour
{
    // Start is called before the first frame update

    public float topBound = 30.0f;
    public float lowerBound = -10.0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        } 
        else if (transform.position.z < -10)
        {
            Destroy(gameObject);

        }
    }
}
