using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {

    public bool autoPlay = false;

    private Ball ball;

    void Start()
    {
        ball = FindObjectOfType<Ball>();
    }
	
	// Update is called once per frame
	void Update () {
        if (!autoPlay)
        {
            moveWithMouse();
        }
        else
        {
            AutoPlay();
        }
	}

    void AutoPlay()
    {
        Vector2 ballPosition = ball.transform.position;
        Vector3 pos = new Vector3(ballPosition.x, transform.position.y, 0);
        transform.position = pos;
    }

    void moveWithMouse()
    {
        float blockPosition = Input.mousePosition.x / Screen.width * 16;
        blockPosition = Mathf.Clamp(blockPosition, 0.5f, 15.5f);
        Vector3 pos = new Vector3(blockPosition, transform.position.y, 0);
        transform.position = pos;
    }
}
