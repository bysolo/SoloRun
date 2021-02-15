using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CubukCodeV : MonoBehaviour
{
    //3. ve 5. Silindirlerin çalışmasını sağlar.
    void Start()
    {
        rot();
    }
    private void rot()
    {
        transform.DOMoveX((-10), 2).OnComplete((() =>
        {
            transform.DOMoveX((10), 2).OnComplete(() => rot());
        }));
    }
}
