using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{

    [SerializeField] int damageToPlayer = 5;
    GameObject currentTarget;
    float walkSpeed = 2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * walkSpeed);
        setAnimationState();
    }

    private void setAnimationState()
    {
        if (!currentTarget) {
            GetComponent<Animator>().SetBool("isAttacking", false);
        }
    }

    public void setMovememtSpeed(float speed) {
        walkSpeed = speed;
    }

    public void attack(GameObject target) {
        GetComponent<Animator>().SetBool("isAttacking", true);
        currentTarget = target;
    }

    public void strikeCurrentTarget(float damage) {
        if (!currentTarget)
            return;

        Health health = currentTarget.GetComponent<Health>();
        if (health) {
            health.dealDamage(damage);
        }
    }

    public int getDamage() {
        return damageToPlayer;
    }
}


