using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HomeScript : MonoBehaviour
{
    public Button button;
    public string sceneLoad;
    // Start is called before the first frame update
    void Start()
    {
        button.onClick.AddListener(loadLevel);
    }
    
    private void loadLevel()
    {
        SceneManager.LoadScene(sceneLoad);
    }
}
