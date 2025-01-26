using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject cameraTarget;
    public Transform targetLock;
    public GameObject camera;
    public Transform cameraPosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(UnityEngine.Collider playerCheck)
    {

        if(playerCheck.gameObject == cameraTarget)
        {
            camera.transform.position = cameraPosition.transform.position;
        }
        else
        {

        }

    }
}
