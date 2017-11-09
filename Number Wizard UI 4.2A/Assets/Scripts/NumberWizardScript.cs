using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NumberWizardScript : MonoBehaviour {

    public Text myGuess;
    System.Random rand = new System.Random();
    int maxGuesses = 5;

    int min = 0;
    int max = 0;
    int guess = 0;

    // Use this for initialization
    void Start () {

        StartGame();
		
	}
	
	// Update is called once per frame
	void Update () {

        if (maxGuesses < 0)
        {
            SceneManager.LoadScene("Win");
        }

        if (Input.GetKeyDown("up"))
        {

        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            StartGame();
        }

    }

    void StartGame()
    {
        min = 1;
        max = 1000;
        //guess = 500;
        NextGuess();
    }

    void NextGuess()
    {
        guess = rand.Next(min,max);
        myGuess.text = guess + "?";
    }

    public void GuessHigher()
    {
        min = guess + 1;
        maxGuesses--;
        NextGuess();
    }

    public void GuessLower()
    {
        max = guess;
        maxGuesses--;
        NextGuess();
    }
}
