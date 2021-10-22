using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtlasController : MonoBehaviour
{
    Rigidbody r;
    [SerializeField]
    float speed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        r = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            r.AddForce(0f, 0f, speed);
        } 
        if (Input.GetKey(KeyCode.S))
        {
            r.AddForce(0f, 0f, -speed);
        } 
        if (Input.GetKey(KeyCode.A))
        {
            r.AddForce(-speed, 0f, 0f);
        } 
        if (Input.GetKey(KeyCode.D))
        {
            r.AddForce(speed, 0f, 0f);
        }
      
    }
}
