using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour {

	public float speed;
	
	void Update ()
	{
		transform.position = Vector3.MoveTowards(transform.position, new Vector3 (-10.0f, transform.position.y, transform.position.z), speed);
//		rigidbody.velocity = new Vector3(-1, 0, 0) * speed;

		if(transform.position.x < -9){
			Destroy(this.gameObject);
		}
	}



}
