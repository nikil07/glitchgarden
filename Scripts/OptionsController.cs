using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;
    [SerializeField] float defaultVolume = 0.4f;

    [SerializeField] Slider difficultySlider;
    [SerializeField] float defaultDifficulty = 0f;

    // Start is called before the first frame update
    void Start()
    {
        volumeSlider.value = PlayerPrefsController.getVolume();
        difficultySlider.value = PlayerPrefsController.getDifficulty();
    }

    // Update is called once per frame
    void Update()
    {
        var musicPlayer = FindObjectOfType<MusicPlayer>();
        if (musicPlayer != null)
        {
            musicPlayer.setVolume(volumeSlider.value);
        }
        else
            Debug.LogWarning("No music player found");
    }

    public void saveAndExit() {
        PlayerPrefsController.setVolume(volumeSlider.value);
        PlayerPrefsController.setDifficulty(difficultySlider.value);
        FindObjectOfType<LevelLoader>().loadMainMenu();
    }

    public void setDefaults() {
        volumeSlider.value = defaultVolume;
        difficultySlider.value = defaultDifficulty;
        PlayerPrefsController.setVolume(defaultVolume);
        PlayerPrefsController.setDifficulty(defaultDifficulty);
    }
}
