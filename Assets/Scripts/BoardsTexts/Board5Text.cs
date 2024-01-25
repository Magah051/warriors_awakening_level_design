using System;
using System.Collections;
using TMPro;
using UnityEngine;

public class Board5Text : MonoBehaviour
{

    public float typeDelay = 0.05f;
    public TextMeshProUGUI textObject;
    string fullText = "Truth is your sharpest sword; never wield it with lies.";

    void Start()
    {
        StartCoroutine(TypeText());
    }


    IEnumerator TypeText()
    {

        textObject.text = fullText;
        textObject.maxVisibleCharacters = 0;
        for (int i = 0; i <= textObject.text.Length; i++)
        {
            textObject.maxVisibleCharacters = i;
            yield return new WaitForSeconds(typeDelay);
        }
    }

}