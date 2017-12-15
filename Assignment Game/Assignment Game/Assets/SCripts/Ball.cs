using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Ball : MonoBehaviour {

    public System.Random RandInt = new System.Random();
    Text P1Score;

    //public Text P1Score = LevelManage.Score1;
    //public Text P2Score = LevelManage.Score2;

    // Use this for initialization
    void Start () {
    int Direction = RandInt.Next(1, 2);

        if(Direction == 1)
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(-2f, -10f);
        }
        else if (Direction == 2)
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(-2f, -10f);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject collisionObject = collision.gameObject;

        if (collisionObject.tag == "P1")
        {
            LevelManage.Score1++;
            print("Goal for player 1");
            //P1Score = LevelManage.Score1;
            P1Score.text += gameObject.P1Score;
        }
        else if (collisionObject.tag == "P2")
        {
            LevelManage.Score2++;
            print("Goal for player 2");
            ScoreText2.text = LevelManage.Score2.ToString();
        }


        if (collisionObject.name == "Border-down")
        {
            print("Bounced.");
        }
    }
}
