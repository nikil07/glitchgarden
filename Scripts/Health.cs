using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] float health = 100f;
    [SerializeField] GameObject deathVFX;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void dealDamage(float damage) {
        health -= damage;
        if (health <= 0) {
            triggerDeathVFX();
            Destroy(gameObject);
        }
    }

    private void triggerDeathVFX() {
        GameObject VFXObject =  Instantiate(deathVFX, transform.position, transform.rotation);
        Destroy(VFXObject, 0.5f);
    }
}
