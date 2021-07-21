using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beanman : MonoBehaviour
{
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (anim.GetBool("dancing") || anim.GetBool("walking") )
        {
            GetComponent<Transform>().position += GetComponent<Transform>().forward*0.01f;
            if (Random.Range(0, 100) > 98) { GetComponent<Transform>().Rotate(new Vector3(0, 90, 0));  }
        }


        if (Input.GetKeyDown(KeyCode.F))
        {

            anim.SetBool("dancing", !anim.GetBool("dancing"));
            

        }





        if (Input.GetKeyDown(KeyCode.Z))
        {

            anim.SetBool("running",!anim.GetBool("running"));
            if (anim.GetBool("running"))
            {
               GetComponent<Transform>().position += GetComponent<Transform>().forward * 0.1f;
               if (Random.Range(0, 1) > 0.95) GetComponent<Transform>().Rotate(new Vector3(0, 90, 0));
            }

        }
        if (Input.GetKeyDown(KeyCode.V))
        {

            anim.SetBool("walking", !anim.GetBool("walking"));
            

        }


    }
}
