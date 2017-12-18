using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour {

    //Random Values
    public System.Random RandInt = new System.Random();
    
    //Score
    public static int P1Score;
    public static int P2Score;
    //---------/public int buildIndex;
    //Triggers for LMB
    public bool MouseTriggered = false;
    //getScene
    public int CurrentScene;
    //gets all the scenes loaded in the build settings
    //static int totalScene = SceneManager.sceneCountInBuildSettings;
    //public int[] SceneCounter = { SceneManager.GetActiveScene().buildIndex, Scene

    //public Text Player1Score;
    //public Text Player2Score;
    //public string NewScore;

    //public Text P1Score = LevelManage.Score1;
    //public Text P2Score = LevelManage.Score2;

    // Use this for initialization
    void Start() {
        P1Score = 0;
        P2Score = 0;
        //Scene.buildIndex();
        //Player1Score.text = "Test";


            
            //OnMouseClick();
            //return CurrentScene;
        
        }
    //check for mouse click(trigger)
    //bool OnMouseClick()
    //{
    //    if (Input.GetMouseButtonDown(0) == true)
    //    {
    //        MouseTriggered = true;
    //    }
    //    return MouseTriggered;
    //}
    // initializes ball movement is OnMouseClick is met.
    void MoveBall()
    {
            int Direction = RandInt.Next(1, 2);

                if (Direction == 1)
                {
                    this.GetComponent<Rigidbody2D>().velocity = new Vector2(10f, .5f);
                }
                else if (Direction == 2)
                {
                    this.GetComponent<Rigidbody2D>().velocity = new Vector2(-10f, .5f);
                }

      }   

    
    void GetCurrentScene()
    {

        CurrentScene = SceneManager.GetActiveScene().buildIndex;
        //Checks if SceneChanged
        //Scene SceneNumber = SceneManager.GetSceneAt(1);
        if (SceneManager.GetActiveScene().buildIndex != CurrentScene)// || SceneManager.GetSceneByBuildIndex(SceneCounter[2]) != CurrentScene)
        {
            //Initializes ball movement by mouseClick
            MoveBall();
        }
        //Scene SceneNOW = SceneManager.GetActiveScene();

        //int[] IndexScene = new int[5];
        //IndexScene[0] = ;
    }
    
	// Update is called once per frame
	void Update () {

        GetCurrentScene();
        //First Scene Criteria for SCORE.
        if (SceneManager.GetActiveScene().name == "LEVEL_ONE")
        {
            if (P1Score == 5 || P2Score == 5)
            {
                P1Score = 0;
                P2Score = 0;
                SceneManager.LoadScene(sceneBuildIndex: 2);
                MoveBall();
            }
        }
        //Second Scene Criteria for SCORE.
        else if (SceneManager.GetActiveScene().name == "LEVEL_TWO")
        {
            if (P1Score == 10 || P2Score == 10)
            {
                P1Score = 0;
                P2Score = 0;
                SceneManager.LoadScene(sceneBuildIndex: 3);
                MoveBall();
            }
        }
        else if (SceneManager.GetActiveScene().name == "FINAL")
        {
            if (P1Score == 15)// || P2Score == 15)
            {
                P1Score = 0;
                P2Score = 0;
                SceneManager.LoadScene(sceneBuildIndex:4);
                MoveBall();
            }
            else if (P2Score == 15)
            {
                P1Score = 0;
                P2Score = 0;
                SceneManager.LoadScene(sceneBuildIndex: 5);
            }
        }

        //Mouse Initialization for Movement.
        if (Input.GetMouseButtonDown(0) == true)
        {
            MoveBall();
        }

    }
    //int Direction = RandInt.Next(1, 2);

    //    if (Direction == 1)
    //    {
    //        this.GetComponent<Rigidbody2D>().velocity = new Vector2(10f, 0f);
    //    }
    //    else if (Direction == 2)
    //    {
    //        this.GetComponent<Rigidbody2D>().velocity = new Vector2(-10f, 0f);
    //    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject collisionObject = collision.gameObject;

        if (collisionObject.tag == "P1")
        {
            P1Score++;
            //print("Goal for player 1");
            print("Goal for Player 1, "+P1Score);
            
            //P1Score = LevelManage.Score1;
            //P1Score.text += gameObject.P1Score;
        }
        else if (collisionObject.tag == "P2")
        {
            P2Score++;
            //print("Goal for player 2");
            print("Goal for Player 2, " + P2Score);
            //ScoreText2.text = LevelManage.Score2.ToString();
        }


        if (collisionObject.name == "Border-down")
        {
            print("Bounced.");
        }
    }
}
