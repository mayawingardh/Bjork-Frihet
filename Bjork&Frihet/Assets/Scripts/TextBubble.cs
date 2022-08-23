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

    private void Update()
    {
        
    }
}
