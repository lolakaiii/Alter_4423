using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStatistics : MonoBehaviour
{
    [SerializeField] private Text playerText; 
    [SerializeField] private SceneData sceneData;

    private void Start()
    {
        UpdatePlayerInformation();
    }

    public void UpdatePlayerInformation()
    {
        playerText.text = "Health: " + sceneData.health.ToString();
    }

}