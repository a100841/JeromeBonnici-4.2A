using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

    
public class LevelManage : MonoBehaviour {

    //public int Score1 = Ball.P1Score;
    //public int Score2 = Ball.P2Score;
    // Use this for initialization
    void Start () {
        //if (SceneManager.GetSceneByName("Level_One"))
        //{

        //}
	}
	
	// Update is called once per frame
	void Update () {
		//if (Score1 == 5 || Score2 == 5)
  //      {
  //          SceneManager.LoadScene("LEVEL_TWO");
  //      }
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
