using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileFly : MonoBehaviour
{
    // Start is called before the first frame update
    public float projectileSpeed = 40.0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * projectileSpeed * Time.deltaTime);

    }
}
