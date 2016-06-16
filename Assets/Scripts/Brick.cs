using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {

    public int maxHit;

    private int timesHit;

	// Use this for initialization
	void Start () {
        timesHit = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter2D(Collision2D colision)
    {
        timesHit++;
    }
}
