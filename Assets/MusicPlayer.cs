using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {

	// Use this for initialization
    static MusicPlayer instance = null;
    void Start()
    {
        if (instance != null)
        {
            GameObject.Destroy(gameObject);
            Debug.Log("Extra music player destroyed.");
        }
        else {
            instance = this;
            GameObject.DontDestroyOnLoad(gameObject);
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
