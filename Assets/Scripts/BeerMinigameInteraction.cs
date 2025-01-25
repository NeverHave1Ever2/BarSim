using JetBrains.Annotations;
using System;
using UnityEngine;
using UnityEngine.UI;
public class BeerMinigameInteraction : MonoBehaviour
{
    [SerializeField] public Button beerButton;
    [SerializeField] public GameObject progressPanel;
    [SerializeField] public Slider progressBar;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (beerButton.isActiveAndEnabled)
        {
            progressBar.value += 1;
        }
    }
    
}
