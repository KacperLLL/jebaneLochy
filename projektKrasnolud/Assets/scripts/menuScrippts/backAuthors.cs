using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backAuthors : MonoBehaviour
{
    public void back()
    {
        SceneManager.LoadScene("Scenes/menu", LoadSceneMode.Single);
    }
}
