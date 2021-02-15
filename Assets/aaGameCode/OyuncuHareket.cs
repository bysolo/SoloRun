using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OyuncuHareket : MonoBehaviour
{
    public Transform tokmakSpawn;
    public Transform cubukSpawn;
    public Transform silindirSpawn;
    public Transform EndGameSpawn;
    int nereyeCarpmisControl=0;

    public GameObject FinishScorePanel;

    public Camera cam;
    int camNerdeControl=1;
    public GameObject BoyamaCanvas;
    public GameObject Score;

    Animator Anim;
    public GameObject bitisCizgisi;
    public GameObject imlec;
    private bool hitTrig;
    Vector3 BaslangicYeri;

    [SerializeField] float _ilerihiz = 10f;
    [SerializeField] float _lerpSpeed = 5f;   //LerpSpeed tıklandığındaki hareket hızı
    [SerializeField] float _karakterValue = 5f; //KarakterValue Sağ Sol hızını ayarlar

    [SerializeField] Vector2 _clampValues = new Vector2(-15, 15);

    

    //private float yeniPoz;
    private float baslangicPoz;
    // //test için
    [HideInInspector] public InputField sense, velocity, fowardForce;
    [HideInInspector] public Rigidbody _rb;
    public bool canMove;

    [Header("İleri Hareket için Verilecek Güç")]
    public float forwardForce = 5;


    [Header("Yan Hareket için Hassasiyet")]
    [SerializeField]
    private float sideSense = 8;

    [Header("Yan Hareket Hız Sınırlaması")]
    [SerializeField] private float velocityAB; //Hassasiyet ayarı için yaratıldı, bulunan değer alttaki max min velocitylere verilecek
    private float maxVelocity;
    private float minVelocity;


    private float deltaMousePos;
    private Vector3 objectPosition;
    private float firstTouch;
    private float secondTouch;
    private float width = 1;
    private float sideforce;

    private float maxClampX = 20;
    private float minClampX = -20;

    private float yeniPoz;

    private void Awake()
    {
        
        maxVelocity = velocityAB;
        minVelocity = -velocityAB;

        //width = Screen.width/2;
    }
    void GetInputFromTouch() //touchdan input almak için
    {
        if (Input.GetMouseButtonDown(0))
        {
            firstTouch = Input.mousePosition.x / width;
        }

        if (Input.GetMouseButton(0)) //anlık olarak parmak hareketini takip ediyor, picker mekaniğinden kopya çekildi, onun gameplayi ve hissiyatı arandı
        {
            secondTouch = Input.mousePosition.x / width;
            deltaMousePos = (secondTouch - firstTouch) * 100;
            firstTouch = secondTouch;
        }

        if (Input.GetMouseButtonUp(0))
        {
            deltaMousePos = 0;
            _rb.velocity = new Vector3(0, 0, _rb.velocity.z);
        }
    }
    float SideForce()
    {
        sideforce = deltaMousePos * sideSense * Time.deltaTime;
        return sideforce;
    }
    void SideMovement(Rigidbody rb, float maxClampX, float minClampX, float sideSense) //Yanlara hareket
    {
        if (canMove)
        {
            objectPosition = rb.position;
            if (objectPosition.x <= maxClampX && objectPosition.x >= minClampX) //x pozisyonunu max ve min arasında sınırlamak için
            {
                if (deltaMousePos != 0)
                {
                    //rb.AddForce(deltaMousePos * sideSense * senseMultiplier * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
                    rb.velocity = new Vector3(Mathf.Clamp(SideForce(), minVelocity, maxVelocity), 0, rb.velocity.z);
                }
                else rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, rb.velocity.z);
            }
            else
            {
                rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, rb.velocity.z);
                if (objectPosition.x < minClampX)
                {
                    rb.position = new Vector3(minClampX, objectPosition.y, objectPosition.z);
                }
                if (objectPosition.x > maxClampX)
                {
                    rb.position = new Vector3(maxClampX, objectPosition.y, objectPosition.z);
                }
            }
        }
    }

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        baslangicPoz = transform.position.x;

        BaslangicYeri = transform.position;
        Anim = GetComponent<Animator>();

        

    }
    void Update()
    {
        GetInputFromTouch();
        SideMovement(_rb, maxClampX, minClampX, sideSense);
       
        yeniPoz = Mathf.Clamp(transform.position.x + Input.GetAxisRaw("Horizontal") * _karakterValue, baslangicPoz + _clampValues.x, baslangicPoz + _clampValues.y);
    }
    private void FixedUpdate()
    {
        
        //Karakter Hareketi
        _rb.MovePosition(new Vector3(Mathf.Lerp(transform.position.x, yeniPoz, _lerpSpeed * Time.fixedDeltaTime), _rb.position.y, transform.position.z + _ilerihiz * Time.fixedDeltaTime));
        //Debug.Log("fixedCalisti");
    }
    
    private void OnCollisionStay(Collision surekliTemas)
    {
        if (surekliTemas.collider.CompareTag("Silindir"))
        {
            _rb.velocity = new Vector3(-0.5f+_rb.velocity.x, _rb.velocity.y, _rb.velocity.z);

        }
    }
    private void OnCollisionEnter(Collision temas)
    {
        if (temas.collider.CompareTag("Engel"))
        {
            nereyeCarpmisControl = 1;
            Anim.SetTrigger("Carpma");
            //Engel Platformunda Bir engele takıldığında ne yapaması gerektiğini söylemen gereken yer burası
            StartCoroutine(Bekle());
            
        }
        else if (temas.collider.CompareTag("Tokmak"))
        {
            nereyeCarpmisControl = 2;
            Anim.SetTrigger("Carpma");
            //Tokmak Platformunda Bir engele takıldığında ne yapaması gerektiğini söylemen gereken yer burası
            StartCoroutine(Bekle());
        }
        else if (temas.collider.CompareTag("Cubuk"))
        {
            nereyeCarpmisControl = 3;
            Anim.SetTrigger("Carpma");
            //Cubuk Platformunda Bir engele takıldığında ne yapaması gerektiğini söylemen gereken yer burası
            StartCoroutine(Bekle());
        }
        else if (temas.collider.CompareTag("Halka"))
        {
            nereyeCarpmisControl = 4;
            Anim.SetTrigger("Carpma");
            // Halka Platformunda Bir engele takıldığında ne yapaması gerektiğini söylemen gereken yer burası
            StartCoroutine(Bekle());
        }
        else if (temas.collider.CompareTag("AI"))
        {
            Anim.SetTrigger("Carpisma");
            StartCoroutine(carpisma());
            _ilerihiz = _ilerihiz - 5;
        }
        
        else if (temas.collider.CompareTag("bitisCizgisi"))
        {
            //Seviye bittiğinde ne yapaması gerektiğini söylemen gereken yer burası
            imlec.SetActive(false);
            Score.SetActive(false);
            FinishScorePanel.SetActive(true);
            temas.collider.isTrigger = true;
            Anim.SetTrigger("bitisCizgisi");
            _ilerihiz = 5;
            _lerpSpeed = 0;
            _karakterValue = 0;
            transform.position = EndGameSpawn.position;
            _rb.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezeRotation;
            

        }
        else if (temas.collider.CompareTag("boyaCollider"))
        {
            FinishScorePanel.SetActive(false);
            temas.collider.isTrigger = true;
            temas.collider.transform.position=new Vector3(90,0,0);
            Anim.SetTrigger("Boyama");
            _ilerihiz = 0;
            camNerdeControl = 3;
            rot();
            BoyamaCanvas.SetActive(true);
            _rb.constraints = RigidbodyConstraints.FreezePosition;
            //1.968 x
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "CubukGiris")
        {
            camNerdeControl = 1;
            Pos();
            rot();

        }
    }
    public void BoyamaKapabutton()
    {
        BoyamaCanvas.SetActive(false);
    }
    private void Pos()
    {
        if (camNerdeControl == 1)
        {
            cam.transform.DOMoveY((4), 2).OnComplete(() => Pos());
            camNerdeControl = 0;
        }
    }
    private void rot()
    {
        if (camNerdeControl==1)
        {
            cam.transform.DORotate(new Vector3(-7, 0, 0), 2).OnComplete(() => rot());
        }
        else if (camNerdeControl==3)
        {
            cam.transform.DORotate(new Vector3(6, 0, 0), 2).OnComplete(() => rot());
        }
       
    }

    IEnumerator Bekle()
    {
        //Enumerator kullanıyoruz animasyon oynaması için geçiktirici
        yield return new WaitForSeconds(0.5f);
        Anim.SetTrigger("Hareket");
        if (nereyeCarpmisControl==1)
        {
            transform.position = BaslangicYeri;
        }
        else if (nereyeCarpmisControl==2)
        {
            transform.position = tokmakSpawn.transform.position;
        }
        else if (nereyeCarpmisControl == 3)
        {
            transform.position = cubukSpawn.transform.position;
        }
        else if (nereyeCarpmisControl == 4)
        {
            transform.position = silindirSpawn.transform.position;
        }
        
        
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    IEnumerator carpisma()
    {
        yield return new WaitForSeconds(0.3f);
        Anim.SetTrigger("Hareket");
        _ilerihiz = _ilerihiz + 5;
    }





}
