using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using TMPro;


public class SettingsMenuHandler : MonoBehaviour
{
    public AudioMixer masterMixer;

    [SerializeField] private TMP_Dropdown resolutionDropdown;
    private Resolution[] resolutions;
    private List<Resolution> filteredResolutions;
    private float currentRefreshRate;
    private int currentResolutionIndex = 0;

    public Toggle vSync;

    void Start(){

        resolutions = Screen.resolutions;
        filteredResolutions = new List<Resolution>();

        resolutionDropdown.ClearOptions();
        currentRefreshRate = Screen.currentResolution.refreshRate;

        for( int i = 0; i < resolutions.Length; i++ ) {
            if (resolutions[i].refreshRate == currentRefreshRate){
                filteredResolutions.Add(resolutions[i]);
            }
        }

        List<string> options = new List<string>();
        for( int i = 0; i < filteredResolutions.Count; i++) {
            string resolutionOption = filteredResolutions[i].width + "x" + filteredResolutions[i].height + " " + filteredResolutions[i].refreshRate + " Hz";
            options.Add(resolutionOption);
            if(filteredResolutions[i].width == Screen.width && filteredResolutions[i].height == Screen.height) {
                currentResolutionIndex = i;
            }
        }

        resolutionDropdown.AddOptions(options);
        resolutionDropdown.value = currentResolutionIndex;
        resolutionDropdown.RefreshShownValue();
    }

    public void SetResolution( int resolutionIndex ) {
        Resolution resolution = filteredResolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, true);
    }

    public void Volume( float volume ) {
        masterMixer.SetFloat("Volume", volume);
    }
    public void FullScreen( bool isFullScreen ) {
        Screen.fullScreen = isFullScreen;
    }
    public void VSync () {
        if(QualitySettings.vSyncCount == 0) {
            vSync.isOn = false;
        }
        else {
            vSync.isOn = true;
        }
    }

    public void Quality( int quality ) {
        QualitySettings.SetQualityLevel(quality);
    }
}