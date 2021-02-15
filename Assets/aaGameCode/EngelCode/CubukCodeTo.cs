using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class CubukCodeTo : MonoBehaviour
{
      //2. ve 6. Silindirlerin çalışmasını sağlar.
    void Start()
    {
        rot();
    }
    private void rot()
    {
        transform.DOMoveX((-20), 2).OnComplete((() =>
        {
            transform.DOMoveX((20), 2).OnComplete(() => rot());
        }));
    }
}
