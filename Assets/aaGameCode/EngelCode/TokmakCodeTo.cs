using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class TokmakCodeTo : MonoBehaviour
{
    //Ortadaki tokmağın çalışmasını sağlar
    [SerializeField] private float angle=89;     //angle Tokmağın döneceği açı
     
    void Start()
    {
        rot();
    }
    private void rot()
    {
        transform.DORotate(new Vector3(0, 0, -angle), 2).OnComplete((() =>
        {
            transform.DORotate(new Vector3(0, 0, angle), 2).OnComplete(() => rot());
        }));
    }
}
