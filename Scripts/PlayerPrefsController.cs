using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsController : MonoBehaviour
{
    const string MASTER_VOLUME_KEY = "MASTER_VOLUME";
    const string DIFFICULTY_KEY = "DIFFICULTY";
    const float MIN_VOLUME = 0f;
    const float MAX_VOLUME = 1f;

    public static void setVolume(float volume) {
        if (volume >= MIN_VOLUME & volume <= MAX_VOLUME) {
            print("Master voume set to " + volume);
            PlayerPrefs.SetFloat(MASTER_VOLUME_KEY, volume);
    }
        else
            Debug.LogError("Master volume not in range");
    }

    public static float getVolume() {
        return PlayerPrefs.GetFloat(MASTER_VOLUME_KEY);
    }
}
