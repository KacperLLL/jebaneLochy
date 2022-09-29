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
    
    public void newGame()
    {
        SceneManager.LoadScene("Scenes/game");
    }

    public void setBut()
    {
        aut.enabled = set.enabled = nG.enabled = pl.enabled = false;
        autT.color = setT.color = nGt.color =plt.color = new Color(1f, 1f, 1f, 0.2f);
        settings.SetActive(true);
    }

    public void back()
    {
        if(File.Exists(Application.dataPath + "/saves/saveList.json")){//nie dziala po wyjsciu z ustawien odpala sie przycisk
            pl.enabled = true; 
            plt.color = new Color(1f, 1f, 1f, 1f);
        }
        aut.enabled = set.enabled = nG.enabled = true;
        autT.color = setT.color = nGt.color = new Color(1f, 1f, 1f, 1f);
        saves.SetActive(false);
        settings.SetActive(false);
    }

    public void play()
    {
        aut.enabled = set.enabled = nG.enabled = pl.enabled = false;
        autT.color = setT.color = nGt.color = plt.color = new Color(1f, 1f, 1f, 0.2f);
        saves.SetActive(true);
    }

    public void authors()
    {
        SceneManager.LoadScene("Scenes/authors", LoadSceneMode.Single);
    }

    public void q()
    {
        Application.Quit();
        Debug.Log("log");
    }
}