    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingsMenu : MonoBehaviour
{
    // Peliss� ei ole musiikkia tai muutakaan audiota aikataulun vuoksi,
    // mutta testasinpahan t�t�kin
    public AudioMixer audioMixer;
    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("VolumeParam", volume);
    }

    // Fullscreen toimii pelin Build-versiossa
    public void SetFullscreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }
}
