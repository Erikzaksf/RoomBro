using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour {

    static MusicPlayer instance = null;


    // Use this for initialization
	void Awake()
    {
        //kills duplicate players
		Debug.Log ("Music Player Awake" + GetInstanceID ());
        if (instance != null)
        {
            Destroy(gameObject);
            print("dup MusicPlayer dead");
        }

        else
        {   // keeps player alive
            instance = this;
            GameObject.DontDestroyOnLoad(gameObject);
        }
   
	}
}