using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public GameObject pipe;

	public GUIText gameOverText;
	public GUIText scoreText;
	public GUIText restartText;
	public Vector3 spawnValues;
	public int hazardCount;
	public float spawnWait;
	public float startWait;

	private int score;

	bool restart;

	// Use this for initialization
	void Start () {
		StartCoroutine (SpawnWaves ());

		restart = false;

		gameOverText.text = "";
		restartText.text = "";
		scoreText.text = "Score: 0";
	}
	
	// Update is called once per frame
	void Update () {
	
		if (restart)
		{
			if (Input.GetButton("Fire1"))
			{
				Application.LoadLevel (Application.loadedLevel);
			}

			if (Input.GetKeyDown (KeyCode.R))
			{
				Application.LoadLevel (Application.loadedLevel);
			}
		}
	}
	
	IEnumerator SpawnWaves ()
	{
		yield return new WaitForSeconds (startWait);
		while (true)
		{
			Vector3 spawnPosition = new Vector3 (spawnValues.x, Random.Range (spawnValues.y-4.5f, spawnValues.y+2.5f), spawnValues.z);
			Quaternion spawnRotation = Quaternion.identity;
			Instantiate (pipe, spawnPosition, spawnRotation);
			yield return new WaitForSeconds (spawnWait);

		}
	}


	public void GameOver()
	{
		gameOverText.text = "Dead!";
		restartText.text = "Press R to start again";
		restart = true;
	}

	public void AddScore()
	{
		score ++;
		scoreText.text = "Score: "+ score.ToString();

	}
}
