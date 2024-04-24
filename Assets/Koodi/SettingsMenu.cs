    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingsMenu : MonoBehaviour
{
    // Pelissä ei ole musiikkia tai muutakaan audiota aikataulun vuoksi,
    // mutta testasinpahan tätäkin
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
