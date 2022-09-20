using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zmienne : MonoBehaviour
{
    private void Start()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    public List<string> save1 = new List<string>();
    public List<string> save2 = new List<string>();
    public List<string> save3 = new List<string>();
    public List<string> save4 = new List<string>();
    public List<string> save5 = new List<string>();
    public List<string> save6 = new List<string>();
}
