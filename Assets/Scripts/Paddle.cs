using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        float blockPosition = Input.mousePosition.x / Screen.width * 16;
        blockPosition = Mathf.Clamp(blockPosition, 0.5f, 15.5f);

        Vector3 pos = new Vector3(blockPosition, transform.position.y, 0);

        transform.position = pos;
	}
}
