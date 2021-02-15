using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DuvarBoyama : MonoBehaviour
{


    
    public MeshRenderer Duvar; //Boyayacağımız obje
    public Texture2D Firca; //Fırça Texture
    public Vector2Int textureArea; //x:1024, t:1024
    Texture2D texture;
    public Camera Cam;
    void Start()
    {
        texture = new Texture2D(textureArea.x, textureArea.y, TextureFormat.ARGB32, false);
        Duvar.material.mainTexture = texture; //Objenin materyalindeki texturu yeni oluşturduğumuz texture yapıyoruz
        
    }
    void Paint(Vector2 texCoord, Color color)
    {
        texCoord.x *= texture.width;
        texCoord.y *= texture.height;
        Color32[] texPixels = texture.GetPixels32();

        int texPoint =
            (int)texCoord.x +
            ((int)texCoord.y * texture.width);

        texPixels[texPoint] = color;

        texture.SetPixels32(texPixels);
        texture.Apply();
    }
    // Update is called once per frame
    float oluyor = 0;
    public Text Painttxt;
    void Update()
    {

        
        if (Input.GetMouseButton(0))
        {
            RaycastHit hitInfo;
            if (Physics.Raycast(Cam.ScreenPointToRay(Input.mousePosition),out hitInfo))
            {
                
                Debug.Log(hitInfo.textureCoord);
                Paint(hitInfo.textureCoord);
                if (hitInfo.textureCoord.x>0 || hitInfo.textureCoord.y>0)
                {
                    oluyor = oluyor + 0.4f;
                    Painttxt.text ="%"+ oluyor.ToString();
                    if (oluyor >= 100)
                    {
                        SceneManager.LoadScene("anaMenu");
                    }
                }
            }
        }
    }
    private void Paint(Vector2 coordinate)
    {
        coordinate.x *= texture.width; //0-1 değerini tam nokta piksellere çevirir
        coordinate.y *= texture.height; // Yani 0-1024 yapar.
        Color32[] textureC32 = texture.GetPixels32();
        Color32[] FircaC32 = Firca.GetPixels32();
        //Fırçanın ortasının kordinatı
        Vector2Int yarimFirca = new Vector2Int(Firca.width / 2, Firca.height / 2);

        for (int x = 0; x < Firca.width; x++)
        {
            int xPos = x - yarimFirca.x + (int)coordinate.x;
            if (xPos<0 || xPos >=texture.width)
            {
                continue;
            }
            for (int y = 0; y < Firca.height; y++)
            {
                int yPos = y - yarimFirca.y + (int)coordinate.y;
                if (yPos < 0 || yPos >= texture.height)
                {
                    continue;
                }
                if (FircaC32[x+(y*Firca.width)].a >0f)
                {
                    int tPos = xPos + (texture.width * yPos); //x (U) Pozisyonu Y (V) Pozisyonu

                    if (FircaC32[x+(y*Firca.width)].r <textureC32[tPos].r)
                    {
                        textureC32[tPos] = FircaC32[x + (y * Firca.width)];
                    }
                }
            }
        }
        texture.SetPixels32(textureC32); //Array'ı set eder
        texture.Apply();

    }


    

}
