using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SetNavAgentGoal : MonoBehaviour
{
    [SerializeField]
    GameObject agent;
    MoveTo movetToX;
    GameObject mainCamera;

    // transform values for camera positioned for atlasphere

    Vector3 atlasphereCamPos = new Vector3(-26.7f, 12.7f, 11f);

    // transform values for camera positioned for the wall

    Vector3 theWallCamPos = new Vector3(4.5f, 13.3f, 11f);

    // transform values for camera positioned for gym

    Vector3 gymCamPos = new Vector3(2.74f, 13.3f, -24.49f);

    // transform values for camera positioned for hang tough

    Vector3 hangToughCamPos = new Vector3(-26.7f, 13.3f, -27.3f);

    // rotation vectors for camera
    Vector3 xCamRotation = new Vector3(-90f, 0f, 0f);
    Vector3 yCamRotation = new Vector3(0f, 180f, 0f);


    // Start is called before the first frame update
    void Start()
    {
        movetToX = agent.GetComponent<MoveTo>();
        mainCamera = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        gameObject.GetComponent<BoxCollider>().isTrigger = true;
        movetToX.goal = gameObject;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.tag == "Atlasphere")
        {
            SetCameraNorth(atlasphereCamPos);      
        } 
        if (gameObject.tag == "TheWall")
        {
            SetCameraNorth(theWallCamPos);
        } 
        if (gameObject.tag == "HangTough")
        {
            SetCameraSouth(hangToughCamPos);
        } 
        if (gameObject.tag == "Gym")
        {
            SetCameraSouth(gymCamPos);
        }

        gameObject.GetComponent<BoxCollider>().isTrigger = false;

    }

    public void SetCameraSouth(Vector3 pos)
    {
        mainCamera.transform.position = pos;
        mainCamera.transform.Rotate(xCamRotation);
        mainCamera.transform.Rotate(yCamRotation);
    }

    public void SetCameraNorth(Vector3 pos)
    {
        mainCamera.transform.position = pos;
        mainCamera.transform.Rotate(xCamRotation);
    }
}
