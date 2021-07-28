using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BananaMan : MonoBehaviour
{
    GameObject ballInHand;
    int currentTarget;
    public Transform rightHand;
    public Transform player;
    public GameObject ball;
    public void MakingBall()
    {
        GameObject clone;
        clone = Instantiate(ball, rightHand);
        ballInHand = clone;
        Object.Destroy(clone, 3);
        
 
    }

    public void ThrowingBall()
    {
        
        ballInHand.AddComponent<Rigidbody>();
        Vector3 dir = (player.position - ballInHand.transform.position).normalized; 
        ballInHand.GetComponent<Rigidbody>().AddForce(dir * 2000);
        ballInHand.GetComponent<Rigidbody>().mass = 10000;

        ballInHand.transform.SetParent(null);


    }


    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
       
    }

   
       
        
    
}
