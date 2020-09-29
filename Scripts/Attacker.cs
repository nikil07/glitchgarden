using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{

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
    }

    public void setMovememtSpeed(float speed) {
        walkSpeed = speed;
    }

    public void attack(GameObject target) {
        GetComponent<Animator>().SetBool("isAttacking", true);
        currentTarget = target;
    }
}


