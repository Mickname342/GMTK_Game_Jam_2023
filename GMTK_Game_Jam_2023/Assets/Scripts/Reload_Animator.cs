using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reload_Animator : MonoBehaviour
{
    GameObject levelManager;
    ReloadSceneScript reload;
    Load_Next_Level load;
    void Start()
    {
        levelManager = GameObject.Find("Level Manager");
        reload = levelManager.GetComponent<ReloadSceneScript>();
        load = levelManager.GetComponent<Load_Next_Level>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReloadScene()
    {
        reload.ReloadLevel();
    }

    public void LoadNextLevel()
    {
        load.LoadNextLevel();
    }
}
