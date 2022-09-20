using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using System.IO;

public class sceneChange : MonoBehaviour
{
    public Button pl, nG, set, aut;
    public GameObject saves;
    public GameObject settings;
    public TextMeshProUGUI plt, nGt, setT, autT;

    public TextMeshProUGUI s1, s2, s3, s4, s5, s6;
    public zmienne zm;

    string path = "save.txt";


    bool save = true;


    public void newGame()
    {
        if(!File.Exists(path))
        {
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine("empty");
                sw.WriteLine("#");
                sw.WriteLine("empty");
                sw.WriteLine("#");
                sw.WriteLine("empty");
                sw.WriteLine("#");
                sw.WriteLine("empty");
                sw.WriteLine("#");
                sw.WriteLine("empty");
                sw.WriteLine("#");
                sw.WriteLine("empty");

            }
        }

        SceneManager.LoadScene("Scenes/game", LoadSceneMode.Single);

    }

    public void setBut()
    {
        pl.enabled = false;
        plt.color = new Color(1f, 1f, 1f, 0.2f);
        nG.enabled = false;
        nGt.color = new Color(1f, 1f, 1f, 0.2f);
        set.enabled = false;
        setT.color = new Color(1f, 1f, 1f, 0.2f);
        aut.enabled = false;
        autT.color = new Color(1f, 1f, 1f, 0.2f);
        settings.SetActive(true);
    }

    public void back()
    {
        pl.enabled = save; 
        if(save)
        {
            plt.color = new Color(1f, 1f, 1f, 1f);
        }

        nG.enabled = true;
        nGt.color = new Color(1f, 1f, 1f, 1f);
        set.enabled = true;
        setT.color = new Color(1f, 1f, 1f, 1f);
        aut.enabled = true;
        autT.color = new Color(1f, 1f, 1f, 1f);
        saves.SetActive(false);
        settings.SetActive(false);
    }

    public void play()
    {
        pl.enabled = false;
        plt.color = new Color(1f, 1f, 1f, 0.2f);
        nG.enabled = false;
        nGt.color = new Color(1f, 1f, 1f, 0.2f);
        set.enabled = false;
        setT.color = new Color(1f, 1f, 1f, 0.2f);
        aut.enabled = false;
        autT.color = new Color(1f, 1f, 1f, 0.2f);
        saves.SetActive(true);
    }

    public void authors()
    {
        SceneManager.LoadScene("Scenes/authors", LoadSceneMode.Single);
    }

    public void Start()
    {
        //protokol zapisu danych w pliku zapisu 1. nazwa zapisu 2. data zapisu 3. nazwa postaci

        save = File.Exists(path);

        //sprawdzenie zapisow
        if(!save)
        {
            pl.enabled = false;
            plt.color = new Color(1f, 1f, 1f, 0.2f);
        }

        
        else
        {
            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                int al = 1; //aktualna linia zczytywana
                int sav1 = 1;


                while ((s = sr.ReadLine())!=null)
                {
                        if(s=="#")
                        {
                            sav1++;
                        }                      
                        else if(sav1==1)
                        {
                            zm.save1.Add(s);
                        }
                        else if(sav1==2)
                        {
                            zm.save2.Add(s);
                        }
                        else if (sav1 == 3)
                        {
                            zm.save3.Add(s);
                        }
                        else if (sav1 == 4)
                        {
                            zm.save4.Add(s);
                        }
                        else if (sav1 == 5)
                        {
                            zm.save5.Add(s);
                        }
                        else if (sav1 == 6)
                        {
                            zm.save6.Add(s);
                        }

                    al++;
                }

            }

            if (zm.save1[0] == "empty")
            {
                pl.enabled = false;
                plt.color = new Color(0f, 0f, 0f, 0.2f);
            }
        }

        

    }

    public void saveCreate()
    {
        if (zm.save1[0] == "empty") s1.text = "Pusto"; else s1.text = zm.save1[0];
        if (zm.save2[0] == "empty") s2.text = "Pusto"; else s2.text = zm.save2[0];
        if (zm.save3[0] == "empty") s3.text = "Pusto"; else s3.text = zm.save3[0];
        if (zm.save4[0] == "empty") s4.text = "Pusto"; else s4.text = zm.save4[0];
        if (zm.save5[0] == "empty") s5.text = "Pusto"; else s5.text = zm.save5[0];
        if (zm.save6[0] == "empty") s6.text = "Pusto"; else s6.text = zm.save6[0];
    }



    public void q()
    {
        Application.Quit();
        Debug.Log("log");
    }
}