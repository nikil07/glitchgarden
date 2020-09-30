using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    bool isSpawn = true;
    [SerializeField] Attacker[] gameObjects;

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
            //yield return new WaitForSeconds(UnityEngine.Random.Range(7f, 6f));
            spawnAttacker();
        }
    }

    private void spawnAttacker()
    {
        Attacker attacker =  Instantiate(gameObjects[Random.Range(0,gameObjects.Length)], transform.position, Quaternion.identity) as Attacker;
        attacker.transform.parent = transform;
    }
}
