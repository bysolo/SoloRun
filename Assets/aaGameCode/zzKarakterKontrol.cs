using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zzKarakterKontrol : MonoBehaviour
{
    public float playerDistance; //oyuncu hareket fark hesaplama
    public GameObject[] Puan;
    public zzPozisyonSc master;
    public float FarkHiz;

    public void PozisyonBul()
    {
        playerDistance = Vector3.Distance(Puan[master.currentPoint].transform.position, this.transform.position);
    }
   /* public void Controls()
    {
        this.GetComponent<Rigidbody>().AddForce(transform.forward * FarkHiz);

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -2, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 2, 0);
        }
    }*/

    // Update is called once per frame
    void Update()
    {
        PozisyonBul();
        //Controls();
    }
}
