using System.Collections;
using UnityEngine;

public class NPCCreator : MonoBehaviour
{

    public GameObject NPC;
    public int count;
    public int speed;
    public int totalNpcs;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    void Update()
    {
        CustomerFlow(speed);
        if(totalNpcs < 5)
        {
            createNPCs(count);
        }
    }

    IEnumerator CustomerFlow(int flowRate)
    {
        yield return new WaitForSeconds(flowRate);
        createNPCs(count);
    }
    void createNPCs(int amount)
    {
        for(int c = 0; c < amount; c++)
        {
            Instantiate(NPC);
            totalNpcs++;
        }
    }
}
