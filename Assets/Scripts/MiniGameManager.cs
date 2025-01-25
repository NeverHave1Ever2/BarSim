using UnityEngine;
using UnityEngine.SceneManagement;

public class MiniGameManager : MonoBehaviour
{
    bool MGPlaying = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) && !MGPlaying)
        {
            MGPlaying = true;
            SceneManager.LoadScene("MGScene", LoadSceneMode.Additive);
        }

        if (Input.GetKeyDown(KeyCode.Escape) && MGPlaying)
        {
            MGPlaying = false;
            SceneManager.UnloadSceneAsync("MGScene");
        }

    }
}
