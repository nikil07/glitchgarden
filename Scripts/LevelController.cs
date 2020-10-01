using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    public int attackersLeft;
    bool isLevelFinished = false;
    [SerializeField] GameObject winLabel;
    [SerializeField] GameObject loseLabel;


    // Start is called before the first frame update
    void Start()
    {
        winLabel.SetActive(false);
        loseLabel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addAttackers() {
        attackersLeft++;
    }

    public void subtractAttackers() {
        attackersLeft--;
        if (attackersLeft == 0 && isLevelFinished) {
            stopSpawners();
            StartCoroutine(handleWinCondition());
        }
    }

    public int getAttackersLeft() {
        return attackersLeft;
    }

    public void setLevelFinished() {
        isLevelFinished = true;
    }

    IEnumerator handleWinCondition()
    {
        winLabel.SetActive(true);
        GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(5);
        FindObjectOfType<LevelLoader>().loadGameOverScene();
    }

    public void handleLoseCondition() {
        loseLabel.SetActive(true);
        Time.timeScale = 0;
    }
    private void stopSpawners()
    {
        Spawner[] spawners = FindObjectsOfType<Spawner>();
        foreach (Spawner spawner in spawners) {
            spawner.stopSpawning();
        }
    }
}
