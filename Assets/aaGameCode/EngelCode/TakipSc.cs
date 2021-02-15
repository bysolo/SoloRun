using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TakipSc : MonoBehaviour
{
    void Start()
    {
        rot();
    }
    private void rot()
    {
        transform.DOMoveX((50), 2).OnComplete((() =>
        {
            transform.DOMoveX((-50), 2).OnComplete(() => rot());
        }));
    }
}
