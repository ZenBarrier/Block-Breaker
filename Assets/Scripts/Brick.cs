using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {
    
    public Sprite[] hitSprite;
    public AudioClip crack;
    public GameObject smoke;

    public static int breakableCount = 0;

    private bool isBreakable;
    private int timesHit;
    private LevelManager levelManagager;

	// Use this for initialization
	void Start () {
        levelManagager = GameObject.FindObjectOfType<LevelManager>();
        isBreakable = (this.tag == "Breakable");
        timesHit = 0;
        if (isBreakable)
        {
            breakableCount++;
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter2D(Collision2D colision)
    {
        

        if (isBreakable)
        {
            AudioSource.PlayClipAtPoint(crack,this.transform.position);
            HandleHits();
        }
    }

    void HandleHits()
    {
        int maxHit = hitSprite.Length + 1;
        timesHit++;

        if (timesHit >= maxHit)
        {
            Instantiate(smoke, this.transform.position, Quaternion.identity);
            Destroy(gameObject);
            breakableCount--;
            levelManagager.BrickDestroyed();
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
        else
        {
            Debug.LogError("Brick Sprite Missing");
        }
    }
}
