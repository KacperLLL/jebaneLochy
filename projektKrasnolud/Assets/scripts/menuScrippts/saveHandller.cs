using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class saveHandller : MonoBehaviour
{
    public Button pl;
    public TextMeshProUGUI plt;
    string path;
    sList lista = new sList();
    public TextMeshProUGUI s1, s2, s3, s4, s5, s6;

    void Start()
    {
        DontDestroyOnLoad(gameObject);

        lista = new sList();
        path = Application.dataPath + "/saves/saveList.json";

        if(File.Exists(path))
        {
            lista = JsonUtility.FromJson<sList>(File.ReadAllText(path));

            if (lista.sInt == 0){
                    pl.enabled = false;
                    plt.color = new Color(0f, 0f, 0f, 0.2f);
            }

            else
            {
                s1.text = lista.S1;
                s2.text = lista.S2;
                s3.text = lista.S3;
                s4.text = lista.S4;
                s5.text = lista.S5;
                s6.text = lista.S6;
            }
        }
        
        else
        {
            string j = JsonUtility.ToJson(lista);
            File.WriteAllText(path, j);
            pl.enabled = false;
            plt.color = new Color(0f, 0f, 0f, 0.2f);
        }

    }
    
    private class sList
    {
        public int sInt;
        public string S1;
        public string S2;
        public string S3;
        public string S4;
        public string S5;
        public string S6;

        public sList()
        {
            sInt = 0;
            S1 = "Pusto";
            S2 = "Pusto";
            S3 = "Pusto";
            S4 = "Pusto";
            S5 = "Pusto";
            S6 = "Pusto";
        }
    }

    private class Saves
    {
        public string s_poziom;
        public string s_name;
        public string s_lvl;
        public string s_money;
    }
}
