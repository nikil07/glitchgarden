using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour
{
    [SerializeField] int buyCost;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addStars(int starsAmount) {
        FindObjectOfType<StarDisplay>().addStars(starsAmount);
    }

    public int getBuyCost() {
        return buyCost;
    }
}
