using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleHandler : MonoBehaviour
{

    [SerializeField] private Transform pfCharacterBattle;
    public Transform creature;
    public Transform rollo;
    public Transform creature2;

    private float RolloHealth;
    private float CreatureHealth;


    private void Start()
    {
        SpawnCreature2();
        SpawnCreature();
        SpawnRollo();
        
    }

    private void SpawnCharacter(bool isPlayerTeam) {
        Vector3 position;
        if (isPlayerTeam)
        {
            position = new Vector3(-90, 0);
        }
        else {
            position = new Vector3(90, 0);
        }
        Instantiate(pfCharacterBattle, position, Quaternion.identity);
    }

    private void SpawnCreature() {
        Vector3 position;
        position = new Vector3(-90, 0);
        Instantiate(creature, position, Quaternion.identity);
    }

    private void SpawnRollo() {
        Vector3 position;
        position = new Vector3(90, 0);
        Instantiate(rollo, position, Quaternion.identity);
    }

    private void SpawnCreature2() {
        Vector3 position;
        position = new Vector3(-90, 20);
        Instantiate(creature2, position, Quaternion.identity);
    }

}
