using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickUp : MonoBehaviour
{
   public AudioSource AmmoPickUpSound;
   void OnTriggerEnter(Collider other)
   {
       AmmoPickUpSound.Play();
       if(AmmoLevel.LoadedAmmo == 0)
       {
        AmmoLevel.LoadedAmmo += 10;
        this.gameObject.SetActive(false);
       }
       else
       {
        AmmoLevel.currentAmmo += 10;
        this.gameObject.SetActive(false);
       }
   }
}
