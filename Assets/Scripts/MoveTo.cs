using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveTo : MonoBehaviour
{
    public GameObject goal;
    public NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        agent = GetComponent<NavMeshAgent>();
        if (goal)
        {
            agent.destination = goal.transform.position;
        }
        
    }
}
