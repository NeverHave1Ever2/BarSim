using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


[Serializable]
public class Beer
{
    private string beerName;
    private int beerPrice;
    private float kegFill;

    public Beer(string name, int price, float fill)
    {
        beerName = name;
        beerPrice = price;
        kegFill = fill;
    }
    public string getName()
    {
        return beerName;
    }

    public int getPrice()
    {
        return beerPrice;
    }
     
    public float kegGet()
    {
        return kegFill;
    }

    public void changeKeg()
    {
        kegFill = 100;
    }

    public void kegUsed(float use)
    {
        kegFill -= use;
    }

}


public class BarManager : MonoBehaviour
{

    bool MGPlaying = false;
    private int cash;
    private int glasses = 20;
    private int dirtyglasses = 0;
    [SerializeField] GameObject player;
    [SerializeField] GameObject interactionPoint;
    [SerializeField] private List<Beer> beers;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        beers.Add(new Beer("Guiness", 4, 100f));
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
                glasses--;
                dirtyglasses++;
                beers[0].kegUsed(10);
                cash += beers[0].getPrice();
                break;
            default:
                MGPlaying = false;
                player.SetActive(true);
                break;

        }
    }
}
