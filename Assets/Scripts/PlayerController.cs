using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    float speed = 12f;
    float translation;
    float straffe;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        translation = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        straffe = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        transform.Translate(straffe, 0, translation);

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0f, -2f, 0f);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0f, 2f, 0f);
        }
    }
}
