using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int EnemyHealth = 10;
    public GameObject Zombie;
    public GameObject ObjectiveComplete;

    void DeductHealth(int DamageAmount)
    {
        EnemyHealth -= DamageAmount;
    }
    void Update()
    {
        if(EnemyHealth <= 0)
        {
            this.GetComponent<ZombieFollow>().enabled = false;
            Zombie.GetComponent<Animation>().Play("Dying");
            StartCoroutine(EndZombie());
            ObjectiveComplete.SetActive(true);
        }
    }

    IEnumerator EndZombie()
    {
        yield return new WaitForSeconds(3);
        Destroy(gameObject);
    }
}
