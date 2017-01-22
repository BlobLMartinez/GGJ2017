using UnityEngine;
using UnityEngine.UI;// we need this namespace in order to access UI elements within our script
using System.Collections;
using UnityEngine.SceneManagement; // neded in order to load scenes

public class CreditsScript : MonoBehaviour {

    public Button retour;

    void Start()
    {
        retour = retour.GetComponent<Button>();
    }

    public void Retour()
    {
        SceneManager.LoadScene("MainMenu");

    }

}
