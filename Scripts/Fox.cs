using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fox : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider)
    {
        
        GameObject otherObject = collider.gameObject;
        if (otherObject.gameObject.name.Contains("Gravestone")) {
            
            jump();
            return; 
        } else if (otherObject.GetComponent<Defender>())
        {
            GetComponent<Attacker>().attack(otherObject);
        } 
    }

    private void jump() {
        GetComponent<Animator>().SetTrigger("jumpTrigger");
    }
}
