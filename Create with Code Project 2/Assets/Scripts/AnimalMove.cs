using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalMove : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 25.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ///constantly move the animals forwatd
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }
}
