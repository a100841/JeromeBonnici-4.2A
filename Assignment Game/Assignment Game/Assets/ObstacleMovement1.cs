using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //this.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -5f);
        if (this.transform.position.y > 4f)
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0f);

            this.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -10f);
        }
        else if (this.transform.position.y < -2.5f)
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0f);

            this.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 10f);
        }


    }
}
