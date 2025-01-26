using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


[Serializable]
public struct Beers
{
    public string BeerName;
    public float KegFill;
}


public class BarManager : MonoBehaviour
{

    bool MGPlaying = false;
    private int cash;
    [SerializeField] GameObject player;
    [SerializeField] GameObject interactionPoint;
    [SerializeField] private List<Beers> beers;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape) && MGPlaying)
        {
            MGPlaying = false;
            SceneManager.UnloadSceneAsync("MiniGame1");
            player.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            BroadcastMessage("serveBeer");
        }
    }

    private void minigameLoad(int minigameCode)
    {
        MGPlaying = true;
        player.SetActive(false);
        switch (minigameCode)
        {
            case (1):
                SceneManager.LoadScene("Minigame1", LoadSceneMode.Additive);
                break;
            default:
                MGPlaying = false;
                player.SetActive(true);
                break;

        }
    }
}
