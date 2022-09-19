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
    public TextMeshProUGUI plt, nGt, setT, autT;

    public TextMeshProUGUI s1, s2, s3, s4, s5, s6;

    bool save = true;


    public void newGame()
    {
        SceneManager.LoadScene("Scenes/game", LoadSceneMode.Single);

    }

    public void back()
    {
        pl.enabled = save; 
        if(save)
        {
            plt.color = new Color(0f, 0f, 0f, 1f);
        }

        nG.enabled = true;
        nGt.color = new Color(0f, 0f, 0f, 1f);
        set.enabled = true;
        setT.color = new Color(0f, 0f, 0f, 1f);
        aut.enabled = true;
        autT.color = new Color(0f, 0f, 0f, 1f);
        saves.SetActive(false);
    }

    public void play()
    {
        pl.enabled = false;
        plt.color = new Color(0f, 0f, 0f, 0.2f);
        nG.enabled = false;
        nGt.color = new Color(0f, 0f, 0f, 0.2f);
        set.enabled = false;
        setT.color = new Color(0f, 0f, 0f, 0.2f);
        aut.enabled = false;
        autT.color = new Color(0f, 0f, 0f, 0.2f);
        saves.SetActive(true);
    }

    public void Start()
    {
        string path = "save.txt";

        save = File.Exists(path);

        //sprawdzenie zapisow
        if(!save)
        {
            pl.enabled = false;
            plt.color = new Color(0f, 0f, 0f, 0.2f);
        }
        
        else
        {

        }

    }

    public void q()
    {
        Application.Quit();
        Debug.Log("log");
    }
}