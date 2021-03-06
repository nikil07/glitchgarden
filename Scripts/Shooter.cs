﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject projectile;
    [SerializeField] GameObject gun;

    private Spawner myLaneSpawner;
    Animator animator;

    GameObject projectileParent;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        setLaneSpawner();
        createProjectileParent();
    }

    private void createProjectileParent()
    {
        projectileParent = GameObject.Find("Projectiles");
        if (!projectileParent) {
            projectileParent = new GameObject("Projectiles");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (isAttackerInLane())
        {
            animator.SetBool("isAttacking", true);
        }
        else
        {
            animator.SetBool("isAttacking", false);
        }
    }

    public void fire() {

        if (isAttackerInLane())
        {
            GameObject newProjectile =  Instantiate(projectile, gun.transform.position, Quaternion.identity) as GameObject;
            newProjectile.transform.parent = projectileParent.transform;
        }
    }

    private void setLaneSpawner() {
        Spawner[] spawners = FindObjectsOfType<Spawner>();
        
        //print(spawners[1].transform.position.y);
        //print(transform.position.y);
        foreach (Spawner spawner in spawners) {
            if (Mathf.Abs(spawner.transform.position.y - Mathf.RoundToInt(transform.position.y)) <= Mathf.Epsilon) {
                myLaneSpawner = spawner;
            }

        }
    }

    private bool isAttackerInLane() {
        return myLaneSpawner.transform.childCount > 0;
    }
}
