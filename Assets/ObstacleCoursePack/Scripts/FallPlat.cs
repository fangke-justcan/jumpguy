using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallPlat : MonoBehaviour
{
	public float fallTime = 0.5f;
	public bool ifFall = true;


	void OnCollisionEnter(Collision collision)
	{
		if (ifFall)
		{
			foreach (ContactPoint contact in collision.contacts)
			{
				//Debug.DrawRay(contact.point, contact.normal, Color.white);
				if (collision.gameObject.tag == "Player")
				{
					StartCoroutine(Fall(fallTime));
				}
			}
        }
		
	}

	IEnumerator Fall(float time)
	{
		yield return new WaitForSeconds(time);
		Destroy(gameObject);
	}
}
