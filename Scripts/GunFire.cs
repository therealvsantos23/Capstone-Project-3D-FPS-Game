using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunFire : MonoBehaviour
{
    private AudioSource gunSound;
    private Animation anim;

    public GameObject Flash;

    void Start()
    {
        gunSound = GetComponent<AudioSource>();
        anim = GetComponent<Animation>();
    }
    void Update()
    {
      if(AmmoLevel.LoadedAmmo >= 1)
      {
        if(Input.GetButtonDown("Fire1"))
        {
            gunSound.Play();
            Flash.SetActive(true);
            StartCoroutine(MuzzleOff());
            anim.Play("GunShot");
            AmmoLevel.LoadedAmmo -= 1;
        }
      }
    }

    IEnumerator MuzzleOff()
    {
        yield return new WaitForSeconds(0.1f);
        Flash.SetActive(false);
    }
}
