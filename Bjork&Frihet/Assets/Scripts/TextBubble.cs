using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextBubble : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI m_Object;
    [SerializeField] GameObject textBubbleButton;
    [SerializeField] GameObject closeButton;


    void Start()
    {
        m_Object.text = "Text Bubble";
    }

    public void CloseTextBubble()
    {
        textBubbleButton.SetActive(false);
        closeButton.SetActive(false);
    }

    public void ClickTextBubble()
    {
        m_Object.text = "Test if close icon stays in correct position";
    }

    private void Update()
    {
        
    }
}
