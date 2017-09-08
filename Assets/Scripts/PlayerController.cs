using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour 
{
	public float speed;

	public GameController gameController;
	public GameObject explosion;

	private bool willBounce = true;
	void FixedUpdate()
	{

		if (Input.GetButton("Fire1") || Input.GetButton("Space") || willBounce)
		{
			Bounce();
		}

	}

	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.tag == "Score")
		{
			Debug.Log ("score");
			Destroy(other.gameObject);
			
			gameController.AddScore();

			
		}

		
	}

	void OnCollisionEnter(Collision Trampoline)
	{
		if (Trampoline.gameObject.tag == "Floor")
		{

			Destroy(this.gameObject);
			
			Instantiate(explosion, transform.position, transform.rotation);

			willBounce = true;
			gameController.GameOver();
		}

		if (Trampoline.gameObject.tag == "Pipes")
		{
			Debug.Log ("Pipes");

			Destroy(this.gameObject);

			Instantiate(explosion, transform.position, transform.rotation);

			gameController.GameOver();
		}


	}

	void Bounce()
	{
		GetComponent<Rigidbody>().velocity = new Vector3(0.0f, 8, 00.0f);
		
//		rigidbody.velocity = transform.forward * rigidbody.velocity.magnitude;

		GetComponent<Rigidbody>().AddForce(0.0f, 0.0f, 0.0f, ForceMode.Impulse);
		
		GetComponent<Rigidbody>().angularVelocity = new Vector3 (0.0f, 00.0f, -10.0f);
		willBounce = false;
	}

}
