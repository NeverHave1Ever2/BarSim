using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public GameObject partnerPosition;

    void OnTriggerEnter(Collider teleport)
    {

        teleport.gameObject.transform.position = partnerPosition.transform.position;

    }
}
