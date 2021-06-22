using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
	public float speed = 3f;
    float glowIntensity;

    // Update is called once per frame
    void Update()
    {
		transform.Rotate(0f, 0f, speed * Time.deltaTime / 0.01f, Space.Self);
        glowIntensity = GetComponent<MeshRenderer>().material.GetFloat("_glowIntensity");
        glowIntensity = Mathf.Lerp(glowIntensity, 0f, Time.deltaTime);
        GetComponent<MeshRenderer>().material.SetFloat("_glowIntensity", glowIntensity);

    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player") 
        {
              Debug.Log("collis");
             GetComponent<MeshRenderer>().material.SetFloat("_glowIntensity", 1f);
        }

    }



}
