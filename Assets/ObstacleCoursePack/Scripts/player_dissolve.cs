using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_dissolve : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float alpha = Mathf.InverseLerp(10, 0, transform.position.y);
        GetComponent<Material>().SetFloat("_dissolveAmount", 0.5f);

        
    }
}
