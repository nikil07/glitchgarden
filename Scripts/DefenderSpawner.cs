using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    Defender defender;
    GameObject defenderParent;
    const string DEFENDER_PARENT_NAME = "Defenders";

    private void Start()
    {
        createDefenderParent();
    }

    private void createDefenderParent()
    {
        defenderParent = GameObject.Find(DEFENDER_PARENT_NAME);
    }

    private void OnMouseDown()
    {
        print("mouse click");
        spawnDefender();
    }

    public void setSelectedDefender(Defender defenderSelected) {
        defender = defenderSelected;
        if (!defenderParent) {
            defenderParent = new GameObject(DEFENDER_PARENT_NAME);
        }
    }

    private Vector2 getMouseClickPos() {
        Vector2 clickPosition = new Vector2(Input.mousePosition.x,Input.mousePosition.y);
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(clickPosition);
        Vector2 snapPos = new Vector2(Mathf.RoundToInt(worldPos.x), Mathf.RoundToInt(worldPos.y));
        
        return snapPos;
    }

    private void spawnDefender() {
        Defender newDefender = Instantiate(defender, getMouseClickPos(), Quaternion.identity) as Defender;
        newDefender.transform.parent = defenderParent.transform;
        FindObjectOfType<StarDisplay>().spendStars(defender.getBuyCost());
    }
}
