using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {
    
    public Sprite[] hitSprite;

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
        int maxHit = hitSprite.Length + 1;
        timesHit++;

        if (timesHit >= maxHit)
        {
            Destroy(gameObject);
        }
        else
        {
            LoadSprite();
        }
    }

    void LoadSprite()
    {
        int spriteIndex = timesHit - 1;
        if (hitSprite[spriteIndex])
        {
            this.GetComponent<SpriteRenderer>().sprite = hitSprite[spriteIndex];
        }
    }
}
