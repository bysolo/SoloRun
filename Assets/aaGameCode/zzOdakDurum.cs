using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zzOdakDurum : MonoBehaviour
{

    public bool Kullandi;
    public zzPozisyonSc master;

    private void OnTriggerEnter(Collider control)
    {
        if (control.tag=="AI" &&!Kullandi || control.tag=="player" && !Kullandi)
        {
            Kullandi = true;
            master.currentPoint++;
        }
    }



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
