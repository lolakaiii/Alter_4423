using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TextSizeEnter : MonoBehaviour
{

    public Text buttonText;
    int originalFontSize;


    void Start() {
        originalFontSize = buttonText.fontSize;
    }

    void Update() {

    }

    public void changeWithHover() {


        buttonText.fontSize = 46;
    }

    public void changeBack() {

        buttonText.fontSize = originalFontSize;
    }
    
}

