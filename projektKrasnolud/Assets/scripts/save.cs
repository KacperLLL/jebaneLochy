using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class save : MonoBehaviour
{
    public GameObject zapis;
    public TextMeshProUGUI zapis1;
    public TextMeshProUGUI zapis2;


    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            zapis.SetActive(true);
        }
    }

    public void back()
    {
        zapis.SetActive(false);
    }
}
