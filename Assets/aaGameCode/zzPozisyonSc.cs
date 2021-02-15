using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;


public class zzPozisyonSc : MonoBehaviour
{
    public float[] GenelPos;    //ToplamOyuncuSayısı
    public GameObject Player;      //Ana karakter
    public float PlayerPozisyon;    //Ana karakter Pozisyonu
    public GameObject[] AI;         //Yapay zeka
    public int currentPos;          //Oyuncuların mevcut Anlık pozisyon değerini 
    public int currentPoint;        //izlemek için tam sayı
    public Text PosText;
    public void PozisyonHesapla()
    {

        GenelPos[0] = Player.GetComponent<zzKarakterKontrol>().playerDistance;
        GenelPos[1] = AI[0].GetComponent<zzAIKontrol>().yapayDistance;
        GenelPos[2] = AI[1].GetComponent<zzAIKontrol>().yapayDistance;
        GenelPos[3] = AI[2].GetComponent<zzAIKontrol>().yapayDistance;
        GenelPos[4] = AI[3].GetComponent<zzAIKontrol>().yapayDistance;
        GenelPos[5] = AI[4].GetComponent<zzAIKontrol>().yapayDistance;
        GenelPos[6] = AI[5].GetComponent<zzAIKontrol>().yapayDistance;
        GenelPos[7] = AI[6].GetComponent<zzAIKontrol>().yapayDistance;
        GenelPos[8] = AI[7].GetComponent<zzAIKontrol>().yapayDistance;
        GenelPos[9] = AI[8].GetComponent<zzAIKontrol>().yapayDistance;
        GenelPos[10] = AI[9].GetComponent<zzAIKontrol>().yapayDistance;

        PlayerPozisyon = Player.GetComponent<zzKarakterKontrol>().playerDistance;

        Array.Sort(GenelPos);

        int x = Array.IndexOf(GenelPos, PlayerPozisyon);

        switch (x)
        {
            case 0:
                currentPos = 1;
                break;
            case 1:
                currentPos = 2;
                break;
            case 2:
                currentPos = 3;
                break;
            case 3:
                currentPos = 4;
                break;
            case 4:
                currentPos = 5;
                break;
            case 5:
                currentPos = 6;
                break;
            case 6:
                currentPos = 7;
                break;
            case 7:
                currentPos = 8;
                break;
            case 8:
                currentPos = 9;
                break;
            case 9:
                currentPos = 10;
                break;
            case 10:
                currentPos = 11;
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        PozisyonHesapla();
        
            PosText.text = currentPos.ToString() +  "    / " + GenelPos.Length;
        
        
    }
}
