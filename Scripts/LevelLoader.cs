using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelLoader : MonoBehaviour
{
    int currentSceneIndex;

    // Start is called before the first frame update
    void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (currentSceneIndex == 0) {
            StartCoroutine(WaitForTime());
        }
    }

    IEnumerator WaitForTime()
    {
        yield return new WaitForSeconds(4);
        loadStartGame();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void loadStartGame() {
        SceneManager.LoadScene("Start Screen");
    }

    public void loadNextScene() {
        SceneManager.LoadScene("GamePlay Screen");
    }

    public void loadGameOverScene() {
        SceneManager.LoadScene("GameOver Screen");
    }
}
