using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnalogMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

       //if (this.transform.position.y >= 3.77f)
       //{
       //     Vector3 positiony = this.transform.position;
       //     positiony = 3.77;
       //}

        if (Input.GetKey(KeyCode.UpArrow))
        {
            Vector3 position = this.transform.position;
            position.y++;
            this.transform.position = position;
            if (this.transform.position.y >= 3.69f)
            {
                //Vector3 Setpositiony = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y , gameObject.transform.position.z);
                this.transform.position = new Vector3(transform.position.x, 3.69f, transform.position.z);
            }

        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Vector3 position = this.transform.position;
            position.y--;
            this.transform.position = position;
            if (this.transform.position.y <= -3.69f)
            {
                //Vector3 Setpositiony = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y , gameObject.transform.position.z);
                this.transform.position = new Vector3(transform.position.x, -3.69f, transform.position.z);
            }
        }

        //if (Input.GetKey(KeyCode.DownArrow)

    }
}
