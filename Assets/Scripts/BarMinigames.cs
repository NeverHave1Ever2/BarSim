using UnityEngine;

public class BarMinigames : MonoBehaviour
{

    [SerializeField] GameObject interactionPoint;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void serveBeer()
    {
        Instantiate(interactionPoint, this.transform);
    }
}
