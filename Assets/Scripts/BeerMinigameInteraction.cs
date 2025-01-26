using JetBrains.Annotations;
using System;
using UnityEngine;
using UnityEngine.UI;
public class BeerMinigameInteraction : MonoBehaviour
{
    [SerializeField] public GameObject progressPanel;
    [SerializeField] public Slider progressBar;
    public bool held = false;
    public Sprite fullBeerGlassImage;
    public SpriteRenderer sr;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sr = gameObject.GetComponent<SpriteRenderer>();
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
        if (held == false & progressBar.value != 0)
        {
            Destroy(progressPanel);
            if (progressBar.value !< 700 ^ progressBar.value !> 800)
            {
                sr.sprite = fullBeerGlassImage;
            }
        }
        if (held)
        {
            progressBar.value += 1;
        }

    }
    
}
