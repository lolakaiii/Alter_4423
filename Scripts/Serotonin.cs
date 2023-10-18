using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Serotonin : MonoBehaviour
{
    [SerializeField] private PlayerStatistics playerStats;
    [SerializeField] public SceneData sceneData;

    void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.CompareTag("Player")) {
            Destroy(this.gameObject);

            if(this.gameObject.CompareTag("Serotonin")) {
                sceneData.health += 20;
            }
            else if(this.gameObject.CompareTag("Cortisol")) {
                sceneData.health -= 25;
            }
            else if(this.gameObject.CompareTag("Dopamine")) {
                sceneData.health += 10;
            }
            else if(this.gameObject.CompareTag("Norepinephrine")) {
                sceneData.health -= 10;
            }
        }

        if( sceneData.health <= 0 ) {
            SceneManager.LoadScene("MainMenu");

        }
        playerStats.UpdatePlayerInformation();
    }
    
    //add GABA, Glutamate, Endorphins

}