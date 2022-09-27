using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Test
{
    [SerializeField] public int nazwa { get; set; }
    [SerializeField] public int nazwa2 { get; set; }
    [SerializeField] public int nazwa3 { get; set; }
}
public class sv : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Test test = new Test();

        test.nazwa = 20;
        test.nazwa2 = 50;
        test.nazwa3 = 1000;

        string json = JsonUtility.ToJson(test);

        Debug.Log(json);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
