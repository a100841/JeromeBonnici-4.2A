using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

    
public class LevelManage : MonoBehaviour {

    public static int Score1 = 0;
    public static int Score2 = 0;
    // Use this for initialization
    void Start () {
        //if (SceneManager.GetSceneByName("Level_One"))
        //{

        //}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void LoadNewScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void QuitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }

}
