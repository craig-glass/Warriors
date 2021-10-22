using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentAtlasController : MonoBehaviour
{
    GameObject atlasObject;
    Rigidbody r;
    Vector3 atlasDirection;

    // Start is called before the first frame update
    void Start()
    {
        atlasObject = GameObject.Find("Atlas");
        r = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        atlasDirection = atlasObject.transform.position - transform.position;
        atlasDirection = atlasDirection.normalized;
        r.AddForce(400 * atlasDirection);
    }
}
