using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileDestroyer : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.GetComponent<Attacker>())
        {
            FindObjectOfType<HealthPoints>().dealDamage(collider.GetComponent<Attacker>().getDamage());
            Destroy(collider.gameObject);
            return;
        }
        else {
            Destroy(collider.gameObject);
        }
    }
}
