using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentAtlasRampPush : MonoBehaviour
{
    Rigidbody r;
    GameObject atlasObject;
    [SerializeField]
    Vector3 pushDirection;
    bool onFloor = false;

    // Start is called before the first frame update
    void Start()
    {
        r = GetComponent<Rigidbody>();
        atlasObject = GameObject.Find("Atlas");
    }

    // Update is called once per frame
    void Update()
    {
        if (!onFloor)
        {
            r.AddForce(pushDirection);
        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Floor")
        {
            onFloor = true;
        }
    }

}
