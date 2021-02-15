using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextWritter : MonoBehaviour
{
    private Text uiText;
    private string textTowrite;
    private int characterIndex;
    private float timePerCharacter;
    private float timer;

    public void AddWriter(Text uiText, string textToWrite, float timePerCharacter)
    {
        this.uiText = uiText;
        this.textTowrite = textToWrite;
        this.timePerCharacter = timePerCharacter;
        characterIndex = 0;
    }
    // Update is called once per frame
    void Update()
    {
        if (uiText != null)
        {
            timer -= Time.deltaTime;
            if (timer <= 0f)
            {
                timer += timePerCharacter;
                characterIndex++;
                uiText.text = textTowrite.Substring(0, characterIndex);

                if (characterIndex >= textTowrite.Length)
                {
                    uiText = null;
                    return;
                }
            }
        }
    }
}
