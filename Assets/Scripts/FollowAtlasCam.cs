using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowAtlasCam : MonoBehaviour
{
    Vector3 offset;
    GameObject atlasObject;

    // Start is called before the first frame update
    void Start()
    {
        atlasObject = GameObject.Find("Atlas");
        offset = atlasObject.transform.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = atlasObject.transform.position - offset;
    }
}
