using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class ReloadSceneScript : MonoBehaviour
{

    private void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            ReloadLevel();
        }
    }
    public void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
