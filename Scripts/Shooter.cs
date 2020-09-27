using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject projectile;
    [SerializeField] GameObject gun;

    private Spawner myLaneSpawner;

    // Start is called before the first frame update
    void Start()
    {
        setLaneSpawner();
    }

    // Update is called once per frame
    void Update()
    {
        if (isAttackerInLane()){ 
            
        } 
    }

    private bool attackerInLane()
    {
        throw new NotImplementedException();
    }

    public void fire() {
        
        Instantiate(projectile, gun.transform.position, Quaternion.identity);
    }

    private void setLaneSpawner() {
        Spawner[] spawners = FindObjectsOfType<Spawner>();
        print(spawners);
        foreach (Spawner spawner in spawners) {
            if (Mathf.Abs(spawner.transform.position.y - transform.position.y) <= Mathf.Epsilon) {
                myLaneSpawner = spawner;
            }

        }
    }

    private bool isAttackerInLane() {
        return myLaneSpawner.transform.childCount > 0;
    }
}
