using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    private bool dragging;
    [SerializeField] 
    private AudioSource audioSource;
    [SerializeField]
    private AudioClip pickUpSound, dropSound;
    private Camera mainCamera;
    private Vector2 offset;
    private Vector2 OrgPos;
    [SerializeField]
    private GameObject ett;
    [SerializeField]
    private GameObject tva;
    [SerializeField]
    private GameObject tre;



    private void Awake()
    {
        OrgPos = transform.position;
    }

    private void Start()
    {
        mainCamera = Camera.main;

    }


    private void Update()
    {
        if(!dragging)
        {
            return;
        }

        var mousePos = GetMousePos();

        transform.position = mousePos- offset;
    }

    private void OnMouseDown()
    {
        dragging = true;
        audioSource.PlayOneShot(pickUpSound);

        offset = GetMousePos() - (Vector2) transform.position;
    }

    private void OnMouseUp()
    {

        if (Vector2.Distance(transform.position, ett.transform.position) < 3)
        {
            Debug.Log("HALLÅ");
            transform.position = ett.transform.position;
        }
       
            transform.position = OrgPos;
            dragging = false;
            audioSource.PlayOneShot(dropSound);
       
    }

    Vector2 GetMousePos ()
    {
        return mainCamera.ScreenToWorldPoint(Input.mousePosition); 
    }
}
