using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthPoints : MonoBehaviour
{
    Text hpText;
    [SerializeField] float basePoints = 20;
    float healthPoints;

    private void Start()
    {
        healthPoints = basePoints - PlayerPrefsController.getDifficulty() * 5;
        print(healthPoints);
        hpText = GetComponent<Text>();
        setHP();
    }

    public void dealDamage(int damage) {
        healthPoints -= damage;
        setHP();
        if (healthPoints <= 0) {
            // GAME OVER
            FindObjectOfType<LevelController>().handleLoseCondition();
        }
    }

    private void setHP() {
        hpText.text = healthPoints.ToString();
    }
}
