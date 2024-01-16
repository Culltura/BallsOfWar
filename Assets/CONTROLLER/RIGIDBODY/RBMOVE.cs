using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RBMOVE : MonoBehaviour
{
    public Rigidbody rb;
    public Vector3 InputKey;

    void fxv(Vector3 direction, float force)
    {
        rb.AddForce(direction * force);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
