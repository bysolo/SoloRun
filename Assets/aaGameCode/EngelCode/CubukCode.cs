using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CubukCode : MonoBehaviour
{

    // 1. 4. ve 7. bucukları çalıştırır  
    void Start()
    {
        rot();
    }
    private void rot()
    {
        transform.DOMoveX((20), 3).OnComplete((() =>
        {
            transform.DOMoveX((-20), 3).OnComplete(() => rot());
        }));
    }
}
