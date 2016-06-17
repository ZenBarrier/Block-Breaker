using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {

    public int maxHit;

    private int timesHit;
    private LevelManager levelManagager;

	// Use this for initialization
	void Start () {
        levelManagager = GameObject.FindObjectOfType<LevelManager>();
        timesHit = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter2D(Collision2D colision)
    {
        timesHit++;
        if (timesHit >= maxHit)
        {
            Destroy(gameObject);
        }
    }

    // TODO delete when you can actually win
    void SimulateWin()
    {
        levelManagager.LoadNextLevel();
    }
}
