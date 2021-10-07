using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballCollide : MonoBehaviour
{
    float ballNormalSize = 0f;
    private void Update()
    {
        float ballSize = GetComponent<Renderer>().material.GetFloat("_shine");
        ballSize = Mathf.Lerp(ballSize, ballNormalSize, Time.deltaTime);
        GetComponent<Renderer>().material.SetFloat("_shine", ballSize);
    }
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GetComponent<Renderer>().material.SetFloat("_shine", 1f);
            //Debug.Log("!!");
        }
    }
}
