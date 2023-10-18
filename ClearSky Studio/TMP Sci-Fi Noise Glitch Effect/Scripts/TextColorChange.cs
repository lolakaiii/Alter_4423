using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TextColorChange : MonoBehaviour
{

    public Text returnText;
    private Color returnColor;
    private FontStyle originalFontStyle;
    //private Color purple = new Color(1.0f, 0.0f, 1.0f); 


    void Start() {
        returnColor = returnText.color;
        originalFontStyle = returnText.fontStyle;
    }

    void Update() {

    }

    public void changeWithHover() {


        returnText.color = Color.black;
        returnText.fontStyle = FontStyle.Bold;
    }

    public void changeBack() {

        returnText.color = returnColor;
        returnText.fontStyle = originalFontStyle;
    }
    
}