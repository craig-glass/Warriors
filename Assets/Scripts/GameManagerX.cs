using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerX : MonoBehaviour
{
    [SerializeField]
    GameObject mainMenuObject;
    [SerializeField]
    GameObject mainCamera;
    Vector3 camMainPos = new Vector3(-8f, 54.1f, -15f);
    Vector3 camMainRotation = new Vector3(90f, 0f, 0f);
    SetNavAgentGoal setNavAgentGoalX;

    static bool initialLoad = true;
   

    public static GameMode currentGameMode = GameMode.MainMenu;

    public enum GameMode
    {
        MainMenu,
        Overworld,
        TheWall,
        Atlasphere,
        HangTough,
        Gym
    }

    
    // Start is called before the first frame update
    void Start()
    {
        if (initialLoad && mainMenuObject)
        {
            mainMenuObject.SetActive(true);
            initialLoad = false;
         
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        

        switch (currentGameMode)
        {
            case GameMode.MainMenu: UpdateMainMenu(); break;
            case GameMode.Overworld: UpdateOverworld(); break;
            case GameMode.TheWall: UpdateTheWall(); break;
            case GameMode.Atlasphere: UpdateAtlasphere(); break;
            case GameMode.HangTough: UpdateHangTough(); break;
            case GameMode.Gym: UpdateGym(); break;
        }
    }

    void UpdateMainMenu()
    {
        // Main menu update method
    }
    void UpdateOverworld()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (mainCamera.transform.position == camMainPos)
            {
                mainMenuObject.SetActive(true);
            }

            mainCamera.transform.position = camMainPos;
            mainCamera.transform.localRotation = Quaternion.Euler(camMainRotation);

        }
    }
    void UpdateTheWall()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            LoadOverworld();
           
        }
    }
    void UpdateAtlasphere()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            LoadOverworld();
    
        }
    }
    void UpdateHangTough()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            LoadOverworld();
          
        }
    }
    void UpdateGym()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            LoadOverworld();
  
        }
    }

    void LoadOverworld()
    {

        SceneManager.LoadScene("Overworld");
        currentGameMode = GameMode.Overworld;
    }

    public void StartGame()
    {
        currentGameMode = GameMode.Overworld;
        mainMenuObject.SetActive(false);
    }

    public static void SetGameMode(string tagName)
    {
        switch (tagName)
        {
            case "Overworld": currentGameMode = GameMode.Overworld; break;
            case "TheWall": currentGameMode = GameMode.TheWall; break;
            case "Atlasphere": currentGameMode = GameMode.Atlasphere; break;
            case "HangTough": currentGameMode = GameMode.HangTough; break;
            case "Gym": currentGameMode = GameMode.Gym; break;
        }
    }
}
