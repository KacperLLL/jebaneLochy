using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class saveHandller : MonoBehaviour
{
    string path;
    void Start()
    {
        path = Application.dataPath + "/saves/saveList.json";

        if(!File.Exists(path))
        {
            File.WriteAllText(path, "test");
        }
    }
}
