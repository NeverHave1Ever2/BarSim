using System.Collections;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;

public class NPCbehaviour : MonoBehaviour
{
    public int hair;
    public int pants;
    public int shirt;
    public int skin;
    public int aggression;
    public int wealth;
    public int sobriety;
    
    public int speed;
    private float targetX;
    private float targetZ;
    public Transform npcTarget;
    private Rigidbody rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        //if (npcTarget.position.x > this.transform.position.x)
        //{
        //    targetX = 1;
        //}
        //else if (npcTarget.position.x < this.transform.position.x)
        //{
        //    targetX = -1;
        //}
        //if (npcTarget.position.z > this.transform.position.z)
        //{
        //    targetZ = 1;
        //}
        //else if (npcTarget.position.x < this.transform.position.x)
        //{
        //    targetZ = -1;
        //}
        moveAroundLikeADickhead(10);
    }

    void moveAroundLikeADickhead(int movementSpeed)
    {
        this.transform.position = new Vector3(Random.Range(-movementSpeed, movementSpeed), 2.5f, Random.Range(-movementSpeed, movementSpeed));
        //if(this.transform.position.x == npcTarget.position.x)
        //{
        //    rb.angularVelocity = Vector3.zero;
        //    if(this.transform.position.z == npcTarget.position.z)
        //    {
        //        rb.angularVelocity = Vector3.zero;
        //    }
        //    else
        //    {
        //        rb.AddForce(0, 0, movementSpeed * (targetZ));
        //    }
        //}
        //else
        //{
        //    rb.AddForce(movementSpeed * (targetX), 0, 0);
        //}
    }
}
