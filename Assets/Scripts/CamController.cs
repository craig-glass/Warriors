using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamController : MonoBehaviour
{

    GameObject atlas;

    // Start is called before the first frame update
    void Start()
    {
        atlas = GameObject.Find("Atlas");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = atlas.transform.position;

        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0f, 2f, 0f);
        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0f, -2f, 0f);
        }
    }
}
