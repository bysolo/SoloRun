using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zzAIKontrol : MonoBehaviour
{
    public float yapayDistance;
    public GameObject[] Points;
    public zzPozisyonSc master;
    public void PozisyonBul()
    {
        yapayDistance = Vector3.Distance(Points[master.currentPoint].transform.position, this.transform.position);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PozisyonBul();
    }
}
