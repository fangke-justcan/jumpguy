using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BananaMan : MonoBehaviour
{
    GameObject ballInHand;
    int currentTarget;
    NavMeshAgent agent;
    //public float speed;
    // Start is called before the first frame update

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
        /*
        agent = GetComponent<NavMeshAgent>();
        currentTarget = 0;
        isFollowingPlayer = false;
        agent.SetDestination(wps[currentTarget].transform.position);
        */
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        /*
        Vector3 dectectStart = new Vector3(transform.position.x, playerAIDetection.transform.position.y, transform.position.z);

        
        Debug.DrawLine(dectectStart, dectectStart + transform.forward.normalized*10, Color.red);
        RaycastHit hit;
        Ray ray = new Ray(dectectStart, transform.forward);
        if (Physics.Raycast(ray,out hit, 10))
        {
            if(hit.collider.tag == "AIDetection")
            {
                isFollowingPlayer = true;
                Debug.Log("Following Player");
                
            }
        }
        if (isFollowingPlayer)
        {
            agent.SetDestination(playerAIDetection.transform.position);
            if (Vector3.Distance(dectectStart, playerAIDetection.transform.position)> 10) 
            {   
                isFollowingPlayer = false; 
                agent.SetDestination(wps[currentTarget].transform.position); 
                Debug.Log("NO Following"); 
            }

        }
        else
        {
            if (wps.Length == 0) return;
            if (agent.remainingDistance < 1)
            {
                currentTarget++;
                if (currentTarget == wps.Length) currentTarget = 0;
                agent.SetDestination(wps[currentTarget].transform.position);
            }

            


        }
       

        */
       
        
    }
}
