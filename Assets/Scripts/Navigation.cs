using UnityEngine;
using Firebase.Auth;
using UnityEngine.SceneManagement;

public class Navigation : MonoBehaviour
{
    public GameObject playPanel;
    public GameObject statsPanel;
    public GameObject inventoryPanel;
    public GameObject settingsPanel;

    public void showPlay()
    {
        playPanel.SetActive(true);
        statsPanel.SetActive(false);
        inventoryPanel.SetActive(false);
        settingsPanel.SetActive(false);
    }

    public void showStatistics()
    {
        playPanel.SetActive(false);
        statsPanel.SetActive(true);
        inventoryPanel.SetActive(false);
        settingsPanel.SetActive(false);
    }

    public void showInventory()
    {
        playPanel.SetActive(false);
        statsPanel.SetActive(false);
        inventoryPanel.SetActive(true);
        settingsPanel.SetActive(false);
    }

    public void showSettings()
    {
        playPanel.SetActive(false);
        statsPanel.SetActive(false);
        inventoryPanel.SetActive(false);
        settingsPanel.SetActive(true);
    }

    public void logOut()
    {
        // Log out the current user
        FirebaseAuth.DefaultInstance.SignOut();

        // Load the login scene
        SceneManager.LoadScene("Login");
    }
}
