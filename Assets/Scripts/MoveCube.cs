using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour
{
    GameObject sphere;
    // Start is called before the first frame update
    void Start()
    {
        sphere = GameObject.Find("Atlas");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = sphere.transform.position;
    }
}
