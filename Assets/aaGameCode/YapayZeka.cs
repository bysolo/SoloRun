using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using DG.Tweening;

public class YapayZeka : MonoBehaviour
{
   
    Animator Anim;
    Vector3 BaslangicYeri;

    NavMeshAgent agent;

    public Transform bitisCizgisi;

    public Transform tokmakSpawn;
    public Transform cubukSpawn;
    public Transform silindirSpawn;
    int nereyeCarpmisControl=0;
    
    
    void Start()
    {
        BaslangicYeri = transform.position;
        agent = GetComponent<NavMeshAgent>();
        Anim = GetComponent<Animator>();
    }

    private void Update()
    {
        agent.destination = bitisCizgisi.position;
    }
    private void OnCollisionEnter(Collision temas)
    {
        if (temas.collider.CompareTag("Engel"))
        {
            nereyeCarpmisControl = 1;
            Anim.SetTrigger("Carpma");
            StartCoroutine(Bekle());

        }
        else if (temas.collider.CompareTag("Tokmak"))
        {
            nereyeCarpmisControl = 2;
            Anim.SetTrigger("Carpma");
            StartCoroutine(Bekle());
        }
        else if (temas.collider.CompareTag("Cubuk"))
        {
            nereyeCarpmisControl = 3;
            Anim.SetTrigger("Carpma");
            StartCoroutine(Bekle());
        }
        else if (temas.collider.CompareTag("Halka"))
        {
            nereyeCarpmisControl = 4;
            Anim.SetTrigger("Carpma");
            StartCoroutine(Bekle());
        }
        else if (temas.collider.CompareTag("player"))
        {
            Anim.SetTrigger("Carpisma");
            agent.speed = 10;
            StartCoroutine(carpisma());
            
        }
        else if (temas.collider.CompareTag("AI"))
        {
            Anim.SetTrigger("Carpisma");
            agent.speed = 10;
            StartCoroutine(carpisma());

        }
    }
    IEnumerator Bekle()
    {
        //Enumerator kullanıyoruz animasyon oynaması için geçiktirici
        yield return new WaitForSeconds(0.5f);
        Anim.SetTrigger("Hareket");
        if (nereyeCarpmisControl == 1)
        {
            transform.position = BaslangicYeri;
        }
        else if (nereyeCarpmisControl == 2)
        {
            transform.position = tokmakSpawn.transform.position;
        }
        else if (nereyeCarpmisControl == 3)
        {
            transform.position = cubukSpawn.transform.position;
        }
        else if (nereyeCarpmisControl == 4)
        {
            transform.position = silindirSpawn.transform.position;
        }
        

    }
    IEnumerator carpisma()
    {
        yield return new WaitForSeconds(0.3f);
        Anim.SetTrigger("Hareket");
        agent.speed = 15;
    }
    
    

}
