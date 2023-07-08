using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reload_Animator : MonoBehaviour
{
    GameObject levelManager;
    ReloadSceneScript reload;
    void Start()
    {
        levelManager = GameObject.Find("Level Manager");
        reload = levelManager.GetComponent<ReloadSceneScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReloadScene()
    {
        reload.ReloadLevel();
    }
}
