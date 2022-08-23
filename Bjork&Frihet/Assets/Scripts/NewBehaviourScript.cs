using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI m_Object;

    void Start()
    {
        m_Object.text = "Text Bubble";
    }

    void CloseTextBubble()
    {
        m_Object.text = "";
    }

    private void Update()
    {
        
    }
}
