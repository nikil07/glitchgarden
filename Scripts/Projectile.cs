﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] float damage = 50;
    int angle = 0;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
        //rotateAxe();
        //transform.localRotation = Quaternion.Euler(1f,2f,3f);
    }

    private void rotateAxe()
    {
        angle++;
        transform.localRotation = Quaternion.Euler(0, 0, -angle);
        if (angle == 360)
            angle = 0;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision != null & collision.GetComponent<Health>()!=null)
            collision.GetComponent<Health>().dealDamage(damage);

    }
}
