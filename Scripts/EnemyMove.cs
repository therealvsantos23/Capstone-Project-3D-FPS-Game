using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public GameObject Player;
    public GameObject Enemy;
    public float EnemySpeed;
    public int MoveTrigger;

    void Update()
    {
        if(MoveTrigger == 1)
        {
            EnemySpeed = 0.02f;
            transform.position =  Vector3.MoveTowards(transform.position, Player.transform.position, EnemySpeed);
        }
    }
}
