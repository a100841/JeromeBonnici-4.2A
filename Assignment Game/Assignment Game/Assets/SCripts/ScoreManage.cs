using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Text ScoreP1;
        Text ScoreP2;

        ScoreP2 = GetComponent<Text>();
        ScoreP2.text += gameObject.P2Score;
    }

    // Update is called once per frame
    void Update () {
		
	}
}
