using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using DG.Tweening;

public class SlaytCode : MonoBehaviour
{
    public float hiz, mesafe;
    public bool yurume;
    public Transform karakter;
    Vector3 poz;
    Animator Anim;
    Vector3 BaslangicYeri;

    void Start()
    {

        BaslangicYeri = transform.position;
        Anim = GetComponent<Animator>();
    }
     void Update()
     {
         poz = new Vector3(karakter.position.x, transform.position.y, karakter.position.z);
         mesafe = Vector3.Distance(transform.position, karakter.position);
         if (mesafe > 0)
         {
             yurume = true;

         }
         if (yurume)
         {
             hiz = 7;
             transform.position = Vector3.MoveTowards(transform.position, karakter.position, hiz * Time.deltaTime);
             transform.LookAt(poz);
             Anim.SetTrigger("Hareket");
         }
     }
    private void OnCollisionEnter(Collision temas)
    {
        if (temas.collider.CompareTag("bitisCizgisi"))
        {

            transform.position = BaslangicYeri;
            //hiz = 0;


        }
    }



}
