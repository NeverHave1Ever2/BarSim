using JetBrains.Annotations;
using System;
using UnityEngine;
using UnityEngine.UI;
public class BeerMinigameInteraction : MonoBehaviour
{
    [SerializeField] public GameObject progressPanel;
    [SerializeField] public Slider progressBar;
    public bool held;
    public Image beerGlass;
    public Sprite fullBeerGlassImage;
    public SpriteRenderer sr;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        fullBeerGlassImage = GetComponent<Sprite>();
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetKeyDown(KeyCode.Space))
        {
            held = true;

        } else if (Input.GetKeyUp(KeyCode.Space)){
            held = false;
        }
        if (held)
        {
            progressBar.value += 1;
        }
        if (held = false & progressBar.value != 0)
        {
            if (progressBar.value < 700 || progressBar.value > 800)
            {
                Destroy(progressBar);
                beerGlass.sprite = 
            }
        }
        

    }
    
}
