using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartGameX : MonoBehaviour
{
    Button startButton;
    GameManagerX gameManagerX;

    // Start is called before the first frame update
    void Start()
    {
        gameManagerX = GameObject.Find("GameManager").GetComponent<GameManagerX>();
        startButton = GetComponent<Button>();
        startButton.onClick.AddListener(StartGame);
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void StartGame()
    {
        gameManagerX.StartGame();
    }
}
