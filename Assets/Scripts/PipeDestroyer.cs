using UnityEngine;
using System.Collections;

public class PipeDestroyer : MonoBehaviour {


	void OnTriggerEnter (Collider other)
	{
		Debug.Log("Destroy pitrhepedestroyer");
//		if (other.tag == "Pipes")
//		{
//			Debug.Log("Destroy!!");
//			Destroy (other.gameObject);
//		}
		

	}


	void OnTriggerExit (Collider other) 
	{
		Debug.Log("Destroy piptredestroyer");
//		Destroy(other.gameObject);
	}
}
