using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.AI;

public class SceneLoader : MonoBehaviour
{
    string tagName;


    // Start is called before the first frame update
    void Start()
    {

        tagName = gameObject.tag;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        SceneManager.LoadScene(tagName);
        GameManagerX.SetGameMode(tagName);

    }
}
