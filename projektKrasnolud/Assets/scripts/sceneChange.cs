using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;


public class sceneChange : MonoBehaviour
{
    public Button pl, nG, set, aut;
    public GameObject saves;
    public TextMeshProUGUI plt, nGt, setT, autT;

    bool save = false;


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
        //sprawdzenie zapisow
        if(!save)
        {
            pl.enabled = false;
            plt.color = new Color(0f, 0f, 0f, 0.2f);
        }

    }
}
