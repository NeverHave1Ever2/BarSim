using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MiniGameManager : MonoBehaviour
{
    bool MGPlaying = false;
    [SerializeField] GameObject player;
    [SerializeField] GameObject interactionPoint;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Instantiate(interactionPoint, this.transform);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape) && MGPlaying)
        {
            MGPlaying = false;
            SceneManager.UnloadSceneAsync("MGScene1");
            player.SetActive(true);
        }


    }

    private void minigameLoad(int minigameCode)
    {
        Debug.Log("loading");
        MGPlaying = true;
        SceneManager.LoadScene("MGScene" + minigameCode, LoadSceneMode.Additive);
        player.SetActive(false);
    }
}
