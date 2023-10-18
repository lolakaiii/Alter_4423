using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitLevel : MonoBehaviour
{
    public string scene;
    public bool isNextScene = true;
    [SerializeField] SceneData sceneData;

    void OnTriggerEnter2D(Collider2D player) { 
        sceneData.isNextScene = isNextScene;
        SceneManager.LoadScene(scene);
        if (sceneData.isNextScene)
        {
            sceneData.distance -= 2;
        }
    }
}
