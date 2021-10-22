using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentCam : MonoBehaviour
{
    [SerializeField]
    Transform agent;
    Vector3 offset = new Vector3(0f, 40f, 0f);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = agent.position + offset;
    }
}
