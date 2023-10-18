using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuHandler : MonoBehaviour
{

    public GameObject loading;
    public Slider loadingBar;

    public void LoadingScene(int sceneId) { //"loads mainGamePlayScene
        StartCoroutine(Waiting(sceneId));
    }

    IEnumerator Waiting(int sceneId) {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneId);

        loading.SetActive(true);

        while(!operation.isDone) {
            loadingBar.value = operation.progress;
            yield return null;
        }
    }


   //public void PlayGame(){
        //SceneManager.LoadScene("MainScene");
    //}

    public void Settings(){
        SceneManager.LoadScene("SettingsScene");
    }

    public void QuitGame() {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}