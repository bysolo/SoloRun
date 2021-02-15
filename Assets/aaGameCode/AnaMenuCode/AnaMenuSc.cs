using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEditor;

[DisallowMultipleComponent]
public class AnaMenuSc : MonoBehaviour
{
    [SerializeField] private TextWritter textWriter;
    private Text messageText;
    public AudioSource GameMusic;

    public GameObject menuPanel;
    public GameObject infoPanel;
    public GameObject OptionsPanel;
    public GameObject MusicOnBttn, MusicOffBttn;
    int a = 0;



    private void Awake()
    {
        messageText = transform.Find("message").Find("messageText").GetComponent<Text>();
    }

    
    void Start()
    {
        GameMusic = GetComponent<AudioSource>();

    }
   
    void Update()
    {
        if (a==1)
        {
            textWriter.AddWriter(messageText, "Bu oyun, Panteon Games çalışanı olma aday adayı olan, Hüseyin Çelik tarafından yapılmıştır. Ve tüm hakları saklıdır.                               Şaka şaka sizi seviyorum, iyi ki varsınız!!", .1f);
            a = 2;
            StartCoroutine(Say());
        }
    }

    public void infoButton()
    {
        a = 1;
        infoPanel.SetActive(true);
    }
    
    public void MusicOnButton()
    {
        MusicOffBttn.SetActive(true);
        MusicOnBttn.SetActive(false);
        GameMusic.mute = true;
    }
    public void MusicOffButton()
    {
        MusicOffBttn.SetActive(false);
        MusicOnBttn.SetActive(true);
        GameMusic.mute = false;
    }
    public void ExitButton()
    {
        menuPanel.SetActive(true);
        OptionsPanel.SetActive(false);
    }
    
    public void PlayBttn()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void OptionsBttn()
    {
        menuPanel.SetActive(false);
        OptionsPanel.SetActive(true);
    }
    public void QuitBttn()
    {
    }
    IEnumerator Say()
    {
        yield return new WaitForSeconds(23.30f);
        a = 0;
        infoPanel.SetActive(false);
    }
}
