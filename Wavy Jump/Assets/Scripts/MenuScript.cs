using UnityEngine;
using UnityEngine.UI;// we need this namespace in order to access UI elements within our script
using System.Collections;
using UnityEngine.SceneManagement; // neded in order to load scenes

public class MenuScript : MonoBehaviour
{
    public Button startText;
    public Button creditsText;

    void Start()
    {
        startText = startText.GetComponent<Button>();
        creditsText = creditsText.GetComponent<Button>();
    }

    public void StartLevel()
    {
        SceneManager.LoadScene("Test");

    }

    public void Credits()
    {
        SceneManager.LoadScene("Credits");

    }
}