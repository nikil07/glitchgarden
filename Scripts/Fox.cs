using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fox : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider)
    {
        print("trigger fox");
        GameObject otherObject = collider.gameObject;
        if (otherObject.gameObject.name.Contains("Gravestone")) {
            print("gravestone");
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
