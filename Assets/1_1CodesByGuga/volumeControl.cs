using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class volumeControl : MonoBehaviour
{


    [SerializeField] Slider VolumeSlider;

    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("musicvolume"))
        {
            PlayerPrefs.SetFloat("musicvolume", 1);
            Load();
        }

        else
        {
            Load();
        }
    }

    // Update is called once per frame
    public void ChangeVolume()
    {
        AudioListener.volume = VolumeSlider.value;
        Save();
    }

    private void Load()
    {
        VolumeSlider.value = PlayerPrefs.GetFloat("MusicVolume");
    }

    private void Save()
    {
        PlayerPrefs.SetFloat("musicVolume", VolumeSlider.value);
    }


}
