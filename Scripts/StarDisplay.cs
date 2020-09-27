using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class StarDisplay : MonoBehaviour
{
    [SerializeField] int stars = 0;
    Text starsText;

    // Start is called before the first frame update
    void Start()
    {
        starsText = GetComponent<Text>();
        updateStars();
    }

    private void updateStars() {
        starsText.text = stars.ToString();
    }

    public void addStars(int amount) {
        stars += amount;
        updateStars();
    }

    public void spendStars(int amount) {
        if (stars >= amount)
        {
            stars -= amount;
            updateStars();
        }
        else {
            print("No stars left");
        }
    }
}
