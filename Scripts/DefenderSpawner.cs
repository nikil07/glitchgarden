using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject defender;

    private void OnMouseDown()
    {
        print("mouse click");
        spawnDefender();
    }

    private Vector2 getMouseClickPos() {
        Vector2 clickPosition = new Vector2(Input.mousePosition.x,Input.mousePosition.y);
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(clickPosition);
        Vector2 snapPos = new Vector2(Mathf.RoundToInt(worldPos.x), Mathf.RoundToInt(worldPos.y));
        print(snapPos);
        return snapPos;
    }

    private void spawnDefender() {
        GameObject newDefender = Instantiate(defender, getMouseClickPos(), Quaternion.identity) as GameObject;
    }
}
