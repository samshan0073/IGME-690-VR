using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class BackMain : MonoBehaviour
{
    public InputActionProperty menuButton; 
    public string sceneName = "MainMenu";
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    void OnEnable()
    {
        menuButton.action.Enable();
    }

    void OnDisable()
    {
        menuButton.action.Disable();
    }

    // Update is called once per frame
    void Update()
    {
        if (menuButton.action.triggered)
        {
            SceneManager.LoadScene("Title");
        }
    }
}
