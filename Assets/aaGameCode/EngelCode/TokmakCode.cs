using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class TokmakCode : MonoBehaviour
{

    [SerializeField] private float angle=89;     //angle Tokmağın döneceği açı
    // Start is called before the first frame update     
    void Start()     
    {         
        rot();    
    }            
    private void rot()     
    {         
        transform.DORotate(new Vector3(0, 0, angle), 2).OnComplete((() =>         
    {            
        transform.DORotate(new Vector3(0, 0, -angle), 2).OnComplete(() => rot());         
    }));    
    }
}
