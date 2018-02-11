using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {
    private int Level;

    public void LoadLevels(string name)
    
    {
        Debug.Log("level requested from Level Manager" + name);
        SceneManager.LoadScene(name);
    }
	
    public void QuitLevel()
    {
        Debug.Log("go ahead and quit losser ");
        Application.Quit();
    }

    public void LoadNextLevel()
    {
        // Application.LoadLevel(Application.loadedLevel + 1);
        //LevelBuildNumber = SceneManager.GetSceneByBuildIndex();
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 1);
        
        
        
    }

   
}

