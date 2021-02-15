using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class SilindirCode : MonoBehaviour
{

    private void Update()
    {
        transform.Rotate (new Vector3(0, 0, 10) * Time.deltaTime);
    }
    void Start()
    {

    }
}
    
