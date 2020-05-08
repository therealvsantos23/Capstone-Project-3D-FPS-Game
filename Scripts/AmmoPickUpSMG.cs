using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickUpSMG : MonoBehaviour
{
   public AudioSource AmmoPickUpSound;
   void OnTriggerEnter(Collider other)
   {
       AmmoPickUpSound.Play();
       if(AmmoLevel.LoadedAmmo == 0)
       {
        AmmoLevel.LoadedAmmo += 30;
        this.gameObject.SetActive(false);
       }
       else
       {
        AmmoLevel.currentAmmo += 30;
        this.gameObject.SetActive(false);
       }
   }
}
