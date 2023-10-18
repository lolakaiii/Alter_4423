using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneFader : MonoBehaviour
{
    [SerializeField] Image fadeImage;
    [SerializeField] Color fadeColor = Color.black;
    [SerializeField] float fadeTime = 4f;

    void Start()
    {
        FadeIn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void FadeIn() {
        StartCoroutine(FadeInRoutine());
        IEnumerator FadeInRoutine() {
            float timer = 0f;
            while (timer < fadeTime) { //loop will continue iterating for 1 second
                timer += Time.deltaTime;
                fadeImage.color = new Color(fadeColor.r, fadeColor.g, fadeColor.b, 1f - (timer/fadeTime));
                yield return null; //wait for a single time
            }
            fadeImage.color = Color.clear;
            yield return null;
        }
    }
}
