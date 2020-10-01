using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthPoints : MonoBehaviour
{
    Text hpText;
    [SerializeField] int healthPoints = 20;

    private void Start()
    {
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
