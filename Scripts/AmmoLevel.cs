using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoLevel : MonoBehaviour
{
   public static int currentAmmo;
   public int internalAmmo;
   public static int LoadedAmmo;
   public int InternalLoaded;
   public GameObject LoadedDisplay;
   public GameObject AmmoDisplay;

   void Update()
   {
       internalAmmo = currentAmmo;
       InternalLoaded = LoadedAmmo;
       AmmoDisplay.GetComponent<Text>().text = "" + internalAmmo;
       LoadedDisplay.GetComponent<Text>().text = "" + LoadedAmmo;
   }
}
