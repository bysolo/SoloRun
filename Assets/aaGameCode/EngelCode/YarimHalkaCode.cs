using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class YarimHalkaCode : MonoBehaviour
{
    //Sağ taraftaki yarım halkaları çalıştır
    void Start()
    {
        rot();
    }
    private void rot()
    {
        transform.DOMoveX((8.5f), 1).OnComplete((() =>
        {
            transform.DOMoveX((14), 1).OnComplete(() => rot());
        }));
    }
   
}
