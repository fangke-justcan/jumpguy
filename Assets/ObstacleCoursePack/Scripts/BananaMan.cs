using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BananaMan : MonoBehaviour
{
    public float speed;
    public Transform target;
    Vector3 lookAtGoal;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        lookAtGoal = new Vector3(target.position.x, transform.position.y, target.position.z);

        transform.LookAt(lookAtGoal);
        
        //transform.Translate(0, 0, speed * Time.deltaTime);
        
    }
}
