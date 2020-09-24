using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    bool isSpawn = true;
    [SerializeField] GameObject gameObject;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spwanAttackers());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator spwanAttackers() {

        while (isSpawn)
        {
            yield return new WaitForSeconds(UnityEngine.Random.Range(1f, 4f));
            spawnAttacker();
        }
    }

    private void spawnAttacker()
    {
        Instantiate(gameObject, transform.position, Quaternion.identity);
    }
}
