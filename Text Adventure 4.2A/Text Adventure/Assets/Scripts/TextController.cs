﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

    public Text myText;

    enum States { cell, sheets_0, mirror, lock_0, cell_mirror, sheets_1, lock_1 };

    States myState;

	// Use this for initialization
	void Start () {

        myState = States.cell;

        if (myState == States.cell)
        {
            cell();
        }
        else if (myState == States.sheets_0)
        {
            sheets_0();
        }
        else if (myState == States.mirror)
        {
            
        }
	}
	
	// Update is called once per frame
	void Update () {
		
        
    }

    void cell()
    {
        myText.text = "You're in a prison cell, your task is to escape..\n" +
        "There are some sheets.. dirty sheets on the bed and a mirror on the wall, " +
        "and the door is locked from outside.\n\n" +
        "Press S to view Sheets, M to view Mirror and L to view Lock";

        if (Input.GetKeyDown(KeyCode.S))
        {
            myText.text = "Sheets!";
            myState = States.sheets_0;
        }
        else if (Input.GetKeyDown(KeyCode.M))
        {
            myText.text = "Mirror";
            myState = States.mirror;
        }
        else if (Input.GetKeyDown(KeyCode.L))
        {
            myText.text = "Lock!";
            myState = States.lock_0;
        }
    }

    void sheets_0()
    {
        myText.text = "These are very dirty sheets! They really need to be changed." +
            "\n\n Press on R to return to the cell!";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell;
        }
    }

    void  mirror()
    {
        myText.text = "You are still in your cell, and you STILL want to escape! There are " +
            "since dirty sheets on the bed, a mark where the mirror was, " +
            "and that pesky door is still there, and firmly locked!\n\n" +
            "Press S to view Sheets, or L view Lock";
    }

    void lock_0()
    {
        myText.text = "This is one of the button locks. You have no idea what the " +
            "combination is. You wish you could somehow see where the dirty " +
            "fingerprints were, maybe that would help.\n\n" +
            "Press R to Return to roaming your cell";
    }

    void cell_mirror()
    {
        myText.text = "You are still in your cell, and you STILL want to escape! There are " +
            "some dirty sheets on the bed, a mark where the mirror was, " +
            "and that pesky door is still there, and firmly locked!\n\n" +
            "Press S to view Sheets, or L to view Lock";
    }

    void sheets_1()
    {
        myText.text = "Holding a mirror in your hand doesn't make the sheets look " +
            "any better\n\n" +
            "PRess R to Return to roaming your cell";
    }

    void lock_1()
    {
        myText.text = "You carefully put the mirror throught the bars, and turn it round " +
            "so you can see the lock. You can just make out the fingerprint around " +
            "the buttons. YOu press the dirty buttons, a hear a click.\n\n" +
            "Press O to Open, or R to Return to your cell";
    }

    void freedom()
    {
        myText.text = "YOU ARE FREE!!" +
            "Press P to Play again.";
    }
}
