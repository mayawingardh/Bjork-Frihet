using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextBubble : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI m_Object;

    void Start()
    {
        m_Object.text = "Text Bubble";
    }

    public void CloseTextBubble()
    {
        m_Object.text = "";
    }

    public void ClickTextBubble()
    {
        m_Object.text = "Test if close icon stays in correct position";
    }

    private void Update()
    {
        
    }
}
