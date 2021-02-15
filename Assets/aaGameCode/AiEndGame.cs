using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AiEndGame : MonoBehaviour
{
    public Text and1, and2, and3, and4, and5, and6, and7, and8, and9, and10, and11;
    public GameObject bot1;
    public GameObject bot2;
    public GameObject bot3;
    public GameObject bot4;
    public GameObject bot5;
    public GameObject bot6;
    public GameObject bot7;
    public GameObject bot8;
    public GameObject bot9;
    public GameObject bot10;
    public int siralama=0;
    public Button end1, end2, end3, end4, end5, end6, end7, end8, end9, end10;
    private void OnCollisionEnter(Collision AiEnd)
    {
        
        if (AiEnd.collider.CompareTag("bitisCizgisi"))
        {
            if (name == "Ayse")
            {
                siralama = PlayerPrefs.GetInt("Kacinci");
                siralama = siralama + 1;
                PlayerPrefs.SetInt("Kacinci", siralama);
                switch (siralama)
                {
                    case 1:
                        and1.text = siralama.ToString() + ". YOU";
                        end1.image.color = Color.green;
                        break;
                    case 2:
                        and2.text = siralama.ToString() + ". YOU";
                        end2.image.color = Color.green;
                        break;
                    case 3:
                        and3.text = siralama.ToString() + ". YOU";
                        end3.image.color = Color.green;
                        break;
                    case 4:
                        and4.text = siralama.ToString() + ". YOU";
                        end4.image.color = Color.green;
                        break;
                    case 5:
                        and5.text = siralama.ToString() + ". YOU";
                        end5.image.color = Color.green;
                        break;
                    case 6:
                        and6.text = siralama.ToString() + ". YOU";
                        end6.image.color = Color.green;
                        break;
                    case 7:
                        and7.text = siralama.ToString() + ". YOU";
                        end7.image.color = Color.green;
                        break;
                    case 8:
                        and8.text = siralama.ToString() + ". YOU";
                        end8.image.color = Color.green;
                        break;
                    case 9:
                        and9.text = siralama.ToString() + ". YOU";
                        end9.image.color = Color.green;
                        break;
                    case 10:
                        and10.text = siralama.ToString() + ". YOU";
                        end10.image.color = Color.green;
                        break;
                    case 11:
                        and11.text = siralama.ToString() + ". YOU";
                        break;
                }
            }
            if (name=="SahteBot")
            {
                siralama = PlayerPrefs.GetInt("Kacinci");
                bot1.SetActive(false);
                siralama = siralama + 1;
                PlayerPrefs.SetInt("Kacinci", siralama);
                switch (siralama)
                {
                    case 1:
                        and1.text = siralama.ToString() + ". SahteBot";
                        break;
                    case 2:
                        and2.text = siralama.ToString() + ". SahteBot";
                        break;
                    case 3:
                        and3.text = siralama.ToString() + ". SahteBot";
                        break;
                    case 4:
                        and4.text = siralama.ToString() + ". SahteBot";
                        break;
                    case 5:
                        and5.text = siralama.ToString() + ". SahteBot";
                        break;
                    case 6:
                        and6.text = siralama.ToString() + ". SahteBot";
                        break;
                    case 7:
                        and7.text = siralama.ToString() + ". SahteBot";
                        break;
                    case 8:
                        and8.text = siralama.ToString() + ". SahteBot";
                        break;
                    case 9:
                        and9.text = siralama.ToString() + ". SahteBot";
                        break;
                    case 10:
                        and10.text = siralama.ToString() + ". SahteBot";
                        break;
                    case 11:
                        and11.text = siralama.ToString() + ". SahteBot";
                        break;
                }
            }
            if (name == "GercekBot")
            {
                siralama = PlayerPrefs.GetInt("Kacinci");
                bot2.SetActive(false);
                siralama = siralama + 1;
                PlayerPrefs.SetInt("Kacinci", siralama);
                switch (siralama)
                {
                    case 1:
                        and1.text = siralama.ToString() + ". GercekBot";
                        break;
                    case 2:
                        and2.text = siralama.ToString() + ". GercekBot";
                        break;
                    case 3:
                        and3.text = siralama.ToString() + ". GercekBot";
                        break;
                    case 4:
                        and4.text = siralama.ToString() + ". GercekBot";
                        break;
                    case 5:
                        and5.text = siralama.ToString() + ". GercekBot";
                        break;
                    case 6:
                        and6.text = siralama.ToString() + ". GercekBot";
                        break;
                    case 7:
                        and7.text = siralama.ToString() + ". GercekBot";
                        break;
                    case 8:
                        and8.text = siralama.ToString() + ". GercekBot";
                        break;
                    case 9:
                        and9.text = siralama.ToString() + ". GercekBot";
                        break;
                    case 10:
                        and10.text = siralama.ToString() + ". GercekBot";
                        break;
                    case 11:
                        and11.text = siralama.ToString() + ". GercekBot";
                        break;
                }
            }
            if (name == "SoloBot")
            {
                siralama = PlayerPrefs.GetInt("Kacinci");
                bot3.SetActive(false);
                siralama = siralama + 1;
                PlayerPrefs.SetInt("Kacinci", siralama);
                switch (siralama)
                {
                    case 1:
                        and1.text = siralama.ToString() + ". SoloBot";
                        break;
                    case 2:
                        and2.text = siralama.ToString() + ". SoloBot";
                        break;
                    case 3:
                        and3.text = siralama.ToString() + ". SoloBot";
                        break;
                    case 4:
                        and4.text = siralama.ToString() + ". SoloBot";
                        break;
                    case 5:
                        and5.text = siralama.ToString() + ". SoloBot";
                        break;
                    case 6:
                        and6.text = siralama.ToString() + ". SoloBot";
                        break;
                    case 7:
                        and7.text = siralama.ToString() + ". SoloBot";
                        break;
                    case 8:
                        and8.text = siralama.ToString() + ". SoloBot";
                        break;
                    case 9:
                        and9.text = siralama.ToString() + ". SoloBot";
                        break;
                    case 10:
                        and10.text = siralama.ToString() + ". SoloBot";
                        break;
                    case 11:
                        and11.text = siralama.ToString() + ". SoloBot";
                        break;
                }
            }
            if (name == "Bot")
            {
                siralama = PlayerPrefs.GetInt("Kacinci");
                bot4.SetActive(false);
                siralama = siralama + 1;
                PlayerPrefs.SetInt("Kacinci", siralama);
                switch (siralama)
                {
                    case 1:
                        and1.text = siralama.ToString() + ". Bot";
                        break;
                    case 2:
                        and2.text = siralama.ToString() + ". Bot";
                        break;
                    case 3:
                        and3.text = siralama.ToString() + ". Bot";
                        break;
                    case 4:
                        and4.text = siralama.ToString() + ". Bot";
                        break;
                    case 5:
                        and5.text = siralama.ToString() + ". Bot";
                        break;
                    case 6:
                        and6.text = siralama.ToString() + ". Bot";
                        break;
                    case 7:
                        and7.text = siralama.ToString() + ". Bot";
                        break;
                    case 8:
                        and8.text = siralama.ToString() + ". Bot";
                        break;
                    case 9:
                        and9.text = siralama.ToString() + ". Bot";
                        break;
                    case 10:
                        and10.text = siralama.ToString() + ". Bot";
                        break;
                    case 11:
                        and11.text = siralama.ToString() + ". Bot";
                        break;
                }
            }
            if (name == "MrSolo")
            {
                siralama = PlayerPrefs.GetInt("Kacinci");
                bot5.SetActive(false);
                siralama = siralama + 1;
                PlayerPrefs.SetInt("Kacinci", siralama);
                switch (siralama)
                {
                    case 1:
                        and1.text = siralama.ToString() + ". MrSolo";
                        break;
                    case 2:
                        and2.text = siralama.ToString() + ". MrSolo";
                        break;
                    case 3:
                        and3.text = siralama.ToString() + ". MrSolo";
                        break;
                    case 4:
                        and4.text = siralama.ToString() + ". MrSolo";
                        break;
                    case 5:
                        and5.text = siralama.ToString() + ". MrSolo";
                        break;
                    case 6:
                        and6.text = siralama.ToString() + ". MrSolo";
                        break;
                    case 7:
                        and7.text = siralama.ToString() + ". MrSolo";
                        break;
                    case 8:
                        and8.text = siralama.ToString() + ". MrSolo";
                        break;
                    case 9:
                        and9.text = siralama.ToString() + ". MrSolo";
                        break;
                    case 10:
                        and10.text = siralama.ToString() + ". MrSolo";
                        break;
                    case 11:
                        and11.text = siralama.ToString() + ". MrSolo";
                        break;
                }
            }
            if (name == "BySolo")
            {
                siralama = PlayerPrefs.GetInt("Kacinci");
                bot6.SetActive(false);
                siralama = siralama + 1;
                PlayerPrefs.SetInt("Kacinci", siralama);
                switch (siralama)
                {
                    case 1:
                        and1.text = siralama.ToString() + ". BySolo";
                        break;
                    case 2:
                        and2.text = siralama.ToString() + ". BySolo";
                        break;
                    case 3:
                        and3.text = siralama.ToString() + ". BySolo";
                        break;
                    case 4:
                        and4.text = siralama.ToString() + ". BySolo";
                        break;
                    case 5:
                        and5.text = siralama.ToString() + ". BySolo";
                        break;
                    case 6:
                        and6.text = siralama.ToString() + ". BySolo";
                        break;
                    case 7:
                        and7.text = siralama.ToString() + ". BySolo";
                        break;
                    case 8:
                        and8.text = siralama.ToString() + ". BySolo";
                        break;
                    case 9:
                        and9.text = siralama.ToString() + ". BySolo";
                        break;
                    case 10:
                        and10.text = siralama.ToString() + ". BySolo";
                        break;
                    case 11:
                        and11.text = siralama.ToString() + ". BySolo";
                        break;
                }
            }
            if (name == "Kamil")
            {
                siralama = PlayerPrefs.GetInt("Kacinci");
                bot7.SetActive(false);
                siralama = siralama + 1;
                PlayerPrefs.SetInt("Kacinci", siralama);
                switch (siralama)
                {
                    case 1:
                        and1.text = siralama.ToString() + ". Kamil";
                        break;
                    case 2:
                        and2.text = siralama.ToString() + ". Kamil";
                        break;
                    case 3:
                        and3.text = siralama.ToString() + ". Kamil";
                        break;
                    case 4:
                        and4.text = siralama.ToString() + ". Kamil";
                        break;
                    case 5:
                        and5.text = siralama.ToString() + ". Kamil";
                        break;
                    case 6:
                        and6.text = siralama.ToString() + ". Kamil";
                        break;
                    case 7:
                        and7.text = siralama.ToString() + ". Kamil";
                        break;
                    case 8:
                        and8.text = siralama.ToString() + ". Kamil";
                        break;
                    case 9:
                        and9.text = siralama.ToString() + ". Kamil";
                        break;
                    case 10:
                        and10.text = siralama.ToString() + ". Kamil";
                        break;
                    case 11:
                        and11.text = siralama.ToString() + ". Kamil";
                        break;
                }
            }
            if (name == "JrSolo")
            {
                siralama = PlayerPrefs.GetInt("Kacinci");
                bot8.SetActive(false);
                siralama = siralama + 1;
                PlayerPrefs.SetInt("Kacinci", siralama);
                switch (siralama)
                {
                    case 1:
                        and1.text = siralama.ToString() + ". JrSolo";
                        break;
                    case 2:
                        and2.text = siralama.ToString() + ". JrSolo";
                        break;
                    case 3:
                        and3.text = siralama.ToString() + ". JrSolo";
                        break;
                    case 4:
                        and4.text = siralama.ToString() + ". JrSolo";
                        break;
                    case 5:
                        and5.text = siralama.ToString() + ". JrSolo";
                        break;
                    case 6:
                        and6.text = siralama.ToString() + ". JrSolo";
                        break;
                    case 7:
                        and7.text = siralama.ToString() + ". JrSolo";
                        break;
                    case 8:
                        and8.text = siralama.ToString() + ". JrSolo";
                        break;
                    case 9:
                        and9.text = siralama.ToString() + ". JrSolo";
                        break;
                    case 10:
                        and10.text = siralama.ToString() + ". JrSolo";
                        break;
                    case 11:
                        and11.text = siralama.ToString() + ". JrSolo";
                        break;
                }
            }
            if (name == "Solo")
            {
                siralama = PlayerPrefs.GetInt("Kacinci");
                bot9.SetActive(false);
                siralama = siralama + 1;
                PlayerPrefs.SetInt("Kacinci", siralama);
                switch (siralama)
                {
                    case 1:
                        and1.text = siralama.ToString() + ". Solo";
                        break;
                    case 2:
                        and2.text = siralama.ToString() + ". Solo";
                        break;
                    case 3:
                        and3.text = siralama.ToString() + ". Solo";
                        break;
                    case 4:
                        and4.text = siralama.ToString() + ". Solo";
                        break;
                    case 5:
                        and5.text = siralama.ToString() + ". Solo";
                        break;
                    case 6:
                        and6.text = siralama.ToString() + ". Solo";
                        break;
                    case 7:
                        and7.text = siralama.ToString() + ". Solo";
                        break;
                    case 8:
                        and8.text = siralama.ToString() + ". Solo";
                        break;
                    case 9:
                        and9.text = siralama.ToString() + ". Solo";
                        break;
                    case 10:
                        and10.text = siralama.ToString() + ". Solo";
                        break;
                    case 11:
                        and11.text = siralama.ToString() + ". Solo";
                        break;
                }
            }
            if (name == "Maykil")
            {
                siralama = PlayerPrefs.GetInt("Kacinci");
                bot10.SetActive(false);
                siralama = siralama + 1;
                PlayerPrefs.SetInt("Kacinci", siralama);
                switch (siralama)
                {
                    case 1:
                        and1.text = siralama.ToString() + ". Maykil";
                        break;
                    case 2:
                        and2.text = siralama.ToString() + ". Maykil";
                        break;
                    case 3:
                        and3.text = siralama.ToString() + ". Maykil";
                        break;
                    case 4:
                        and4.text = siralama.ToString() + ". Maykil";
                        break;
                    case 5:
                        and5.text = siralama.ToString() + ". Maykil";
                        break;
                    case 6:
                        and6.text = siralama.ToString() + ". Maykil";
                        break;
                    case 7:
                        and7.text = siralama.ToString() + ". Maykil";
                        break;
                    case 8:
                        and8.text = siralama.ToString() + ". Maykil";
                        break;
                    case 9:
                        and9.text = siralama.ToString() + ". Maykil";
                        break;
                    case 10:
                        and10.text = siralama.ToString() + ". Maykil";
                        break;
                    case 11:
                        and11.text = siralama.ToString() + ". Maykil";
                        break;
                }
            }

        }
        
    }
    void Start()
    {
        siralama = 0;
        PlayerPrefs.SetInt("Kacinci", siralama);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
